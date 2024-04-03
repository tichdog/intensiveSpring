using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public FloatingJoystick joystick;
    private Rigidbody2D rb;
    public float speed = 0.5f;
    private Vector2 moveVector;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        moveVector.x = joystick.Horizontal;
        moveVector.y = joystick.Vertical;

        rb.velocity = Vector2.zero;

        if(moveVector.x > 0)
        {
            rb.velocity += Vector2.right * speed;
        }

        if(moveVector.x < 0)
        {
            rb.velocity += Vector2.left * speed;
        }

        if(moveVector.y > 0)
        {
            rb.velocity += Vector2.up * speed;
        }

        if(moveVector.y < 0)
        {
            rb.velocity += Vector2.down * speed;
        }

        Debug.Log("horizontal " + joystick.Horizontal + "Vertical " + joystick.Vertical);

/*        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);*/
    }

}
