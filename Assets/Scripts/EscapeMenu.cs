using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject escapeMenu;

    // Update is called once per frame
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }

    public void Resume() {
        escapeMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false; 
    }

    void Pause() {
        escapeMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true; 
    }

    public void MainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainPage");
        Debug.Log("Load Main Menu");
    }

    public void Quit() {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

