using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody2D rb;
    bool facingRight = false;
    Vector2 movement;

    void Start() {
       rb = GetComponent<Rigidbody2D>(); 
    }

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");  

        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(moveInput < 0 && facingRight) {
            flip();
        }

        if(moveInput > 0 && !facingRight) {
            flip();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void flip() {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}
