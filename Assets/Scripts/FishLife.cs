using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishLife : MonoBehaviour
{
    public int lifeNum;
    public GameObject[] hearts;
    public int winScore;
    public static int score;

    void Start()
    {
        lifeNum = 3;
        score = winScore;
    }

    private void OnCollisionEnter2D(Collision2D fish)
    {
        if (fish.transform.tag == "Enemies")
        {
            if(lifeNum < 0) lifeNum = 0;
            else if (lifeNum == 1) Destroy(hearts[2].gameObject);
            else if(lifeNum == 2) Destroy(hearts[1].gameObject);
            else if(lifeNum == 3) Destroy(hearts[0].gameObject);
            lifeNum--;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (lifeNum > 0 && ScoreScript.scoreNum >= winScore)
        {
            GameOver.gameSuccess = true;
        }
        else if (lifeNum <= 0)
        {
            GameOver.gameOver = true;
        }
    }
}
