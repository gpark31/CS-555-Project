using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    public float speed = 1f;
    Rigidbody2D rb;
    bool right = true;

    // Start is cddalled before the first frame update
    void Start()
    {
        transform.Rotate(0, 180, 0);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= 150f && transform.position.x < 1700f && right == true)
        {
            rb.velocity = new Vector2(speed, 0f);
        }
        if (transform.position.x >= 1700f && right == true)
        {
            right = false;
            transform.Rotate(0, 180, 0);
            rb.velocity = new Vector2(-speed, 0f);
        }
        if (transform.position.x <= 1700f && transform.position.x > 150f && right == false)
        {
            rb.velocity = new Vector2(-speed, 0f);
        }
        if (transform.position.x <= 150f && right == false)
        {
            right = true;
            transform.Rotate(0, 180, 0);
            rb.velocity = new Vector2(speed, 0f);

        }
    }

}
