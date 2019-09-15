using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonM : MonoBehaviour
{
    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    
    public void startSlow()
    {
        Rotator.speed = 50f;
        SceneManager.LoadScene("MainLevel");
    }

    public void startFast()
    {
        Rotator.speed = 150f;
        SceneManager.LoadScene("MainLevel");
    }

    public void loadEnd()
    {
              SceneManager.LoadScene("end");
    }
}