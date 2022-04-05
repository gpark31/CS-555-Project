using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool gameOver;
    public static bool gameSuccess;
    public GameObject gameOverScreen;
    public GameObject gameSuccessScreen;

    private void Awake()
    {
        gameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            gameOverScreen.SetActive(true);
        }
        if (gameSuccess)
        {
            gameSuccessScreen.SetActive(true);
        }
    }
    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
