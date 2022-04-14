using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {
    public Text scoreText;
    public static int scoreNum = 0;

    void Start()
    {
        scoreNum = 0;
        scoreText.text = "Score: " + scoreNum;
    }

    private void OnTriggerEnter2D(Collider2D Coin) {
        if(Coin.tag == "myCoin") {
            scoreNum++;
            Destroy(Coin.gameObject);
            scoreText.text = "Score: " + scoreNum;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
