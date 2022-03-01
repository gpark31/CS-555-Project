using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame(int l)
    {
        SceneManager.LoadScene(l);
        //if (SceneManager.GetActiveScene() != SceneManager.GetSceneAt(l))
        //{
       //     Debug.Log("Error");
       // }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneAt(0))
        {
            Debug.Log("Error");
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneAt(SceneManager.GetActiveScene().buildIndex + 1))
        {
            Debug.Log("Error");
        }
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
