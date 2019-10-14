using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class restartscript : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("start");
    }

}
