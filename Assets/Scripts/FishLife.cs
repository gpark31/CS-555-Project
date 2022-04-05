using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishLife : MonoBehaviour
{
    public Text life;
    private int lifeNum;

    void Start()
    {
        lifeNum = 0;
        life.text = "Fish Life: " + lifeNum;
    }

    private void OnCollisionEnter2D(Collision2D fish)
    {
        if (fish.transform.tag == "Enemies")
        {
            lifeNum++;
            if(lifeNum > 3)
            {
                lifeNum = 3;
            }
            life.text = "Fish Life: " + lifeNum;
            if (lifeNum >= 3)
            {
                GameOver.gameOver = true;
                gameObject.SetActive(false);
            }
        }
        if(lifeNum < 3 && ScoreScript.scoreNum == 7)
        {
            GameOver.gameSuccess = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
