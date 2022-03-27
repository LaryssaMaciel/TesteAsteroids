using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 movX, movY;
    Rigidbody2D rb;
    SpriteRenderer sr;

    [SerializeField] float speed = 2f;
    // [SerializeField] float jumpForce = 5f;
    // bool onGround = false;
    // Transform groundCheck;
    // bool jump = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        // groundCheck = gameObject.transform.Find("GroundCheck");
    }

    void Update()
    {
        /* onGround = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")); // 
        if (Input.GetKeyDown(KeyCode.W) && onGround == true)
        {
            jump = true;
        }
        */
    }

    void FixedUpdate()
    {
        // Movimentação pros lados
        float movX = Input.GetAxisRaw("Horizontal"); // pega input left/right
        float movY = Input.GetAxisRaw("Vertical"); // pega input up/down
        rb.velocity = new Vector2(movX * speed, movY * speed); // move a posição do obj com a velocidade

        // Pulo
        /*
        if (jump == true)
        {
            rb.AddForce(new Vector2(0, jumpForce));
            jump = false;
        }
        */
        // Flip
        if (movX == -1)
        {
            sr.flipX = true;
        } 
        else if (movX == 1)
        {
            sr.flipX = false;
        }
    }
}
