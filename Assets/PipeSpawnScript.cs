using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5;
    private float timer = 0;
    public float hieghtOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            spawnPipe();
            timer = timer - spawnRate;
        }
        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - hieghtOffset;
        float highestPoint = transform.position.y + hieghtOffset;

        Instantiate(pipe, new Vector3 (transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
