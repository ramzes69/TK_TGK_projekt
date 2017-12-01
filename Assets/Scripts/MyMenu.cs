using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyMenu : MonoBehaviour
{

    public void StartGame()
    {

        //Application.LoadLevel("Level2");
        SceneManager.LoadScene(1);

    }

    public void Quit()
    {
        Application.Quit();
    }
}