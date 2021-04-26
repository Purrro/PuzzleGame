using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{
    public void QuitBtn()
    {
        Application.Quit();
    }

    public void MainMenuBtn()
    {
        Destroy(GameObject.FindGameObjectWithTag("GameAudio"));
        SceneManager.LoadScene("MainMenu");
    }
}
