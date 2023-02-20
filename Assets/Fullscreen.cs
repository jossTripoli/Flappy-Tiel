using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{

    public void Change()
    {
        Debug.Log("FULLSCREEN");
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void ClearHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
