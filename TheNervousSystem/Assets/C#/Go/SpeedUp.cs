using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    // Задаем ускорение для игрока
    private float speed = 0.1f;
    private float maxSpeed = -0.6f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(Road.speed - speed > maxSpeed)
            {
                Road.speed -= speed;
            }
            
            Destroy(gameObject);
        }
    }

    /*private void FixedUpdate()
    {
        gameObject.transform.Translate(new Vector2(0.1f, 0));
    }*/
}
