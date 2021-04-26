using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject InstructionPanel;
    [SerializeField] GameObject StagePanel;

    private string whatStage;

    private bool isStagesActive = false;

    public void PlayBtn()
    {
        isStagesActive = !isStagesActive;
        InstructionPanel.SetActive(!isStagesActive);
        StagePanel.SetActive(isStagesActive);
    }

    public void QuitBtn()
    {
        Application.Quit();
    }

    public void MainMenuBtn()
    {
        Destroy(GameObject.FindGameObjectWithTag("GameAudio"));
        SceneManager.LoadScene("MainMenu");
    }

    public void Stage1Btn()
    {
        SceneManager.LoadScene("Stage1");
    }
    
    public void Stage2Btn()
    {
        SceneManager.LoadScene("Stage2");
    }
    
    public void Stage3Btn()
    {
        SceneManager.LoadScene("Stage3");
    }

}
