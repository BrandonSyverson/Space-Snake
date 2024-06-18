using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public string mainMenuScene = "0";
    public float nextLevelScene = 0;

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(){
        //UpgradeSelection.Reset();
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void LoadLevel2(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(3);
    }

    public void LoadLevel3(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(4);
    }

    public void LoadLevel4(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(6);
    }

    public void LoadLevel5(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(8);
    }


}
