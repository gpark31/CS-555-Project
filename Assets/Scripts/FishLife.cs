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

    private void OnTriggerEnter2D(Collider2D fish)
    {
        if (fish.tag == "fish")
        {
            lifeNum++;
            if(lifeNum >= 3)
            {
                Destroy(fish.gameObject);
            }
            life.text = "Fish Life: " + lifeNum;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
