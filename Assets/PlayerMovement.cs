using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 5f;
    private bool isOnFloor = true;
    [SerializeField] private float jumpForce = 7f;
    private Rigidbody2D rb;
    private Animator AnimatorPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        AnimatorPlayer = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        movePlayer();
        jumpPlayer();
    }

    void movePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        jumpPlayer();
    }

    void jumpPlayer()
    {
        if (Input.GetKey(KeyCode.Space) && isOnFloor)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isOnFloor = false;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isOnFloor = true;
        }

    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isOnFloor = false;
        }
    }
}
