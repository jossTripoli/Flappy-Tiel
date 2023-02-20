using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyAudio : MonoBehaviour
{
    static bool audioBegin = false;
    private void Awake()
    {
        if (!audioBegin)
        {
            DontDestroyOnLoad(transform.gameObject);
            audioBegin = true;
        }
    }
}
