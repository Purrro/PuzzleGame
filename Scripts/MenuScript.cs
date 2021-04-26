using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class  MenuScript : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    private static bool isPaused;

    private void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        Pause();
    }

    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
            pausePanel.SetActive(isPaused ? true : false);
        }
    }

    public void BtnRestart()
    {
        
        isPaused = false;
      //  SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenuBtn()
    {
        Destroy(GameObject.FindGameObjectWithTag("GameAudio"));
        SceneManager.LoadScene("MainMenu");
    }
}
