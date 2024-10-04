using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float speed = 0.1f;
    private bool isOnFloor = true;
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right*Time.deltaTime*speed, Space.World);
        } 
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left*Time.deltaTime*speed, Space.World);
        }
        jumpPlayer();
    }

    void jumpPlayer()
    {
        if (Input.GetKey(KeyCode.W) && isOnFloor)
        {
            rb.AddForce(Vector2.up*jumpForce);
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
