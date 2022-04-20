using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public Text scoreText;
    public static int scoreNum;

    void Start()
    {
        scoreNum = 0;
        scoreText.text = "Score: " + scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Coin) {
        if(scoreNum > FishLife.score)
        {
            scoreNum = FishLife.score;
        }
        if (Coin.tag == "myCoin") {
            Destroy(Coin.gameObject);
            scoreNum++;
            scoreText.text = "Score: " + scoreNum;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
