using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BarrierGo : MonoBehaviour
{
    public GameObject line_1;
    public GameObject line_2;
    public GameObject line_3;

    private Vector3[] vPos = new Vector3[3];
    private float speed = 0.1f;
    private float minSpeed = -0.2f;
    public void Start()
    {
        vPos[0] = line_1.transform.position;
        vPos[1] = line_2.transform.position;
        vPos[2] = line_3.transform.position;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("speedUp"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Player"))
        {
            // Если замедление не остановит нас, то замедляем 
            if(Road.speed + speed < minSpeed)
            {
                Debug.Log("Speed " + Road.speed);
                Road.speed += speed;
                Debug.Log("Speed " + Road.speed);
            }
            // Уменьшаем скорость игрока при прикоснговении к барьеру 

            //Debug.Log("Collider " + collision.transform.position + " // " + vPos[0] + " - " + vPos[1] + " - " + vPos[2]);
            if (collision.transform.position.y == vPos[0].y)
            {
                Debug.Log("1");
                collision.transform.position = vPos[1];
            }
            else if (collision.transform.position.y == vPos[1].y)
            {
                Debug.Log("2");
                int r = Random.Range(1, 3);
                Debug.Log(r + "rand");
                if(r == 1)
                {
                    collision.transform.position = vPos[0];
                }

                if(r == 2)
                {
                    collision.transform.position = vPos[2];
                }

                // ? 
                if(r == 3)
                {
                    collision.transform.position = vPos[2];
                }
            }
            else
            {
                Debug.Log("Collider " + collision.transform.position + " // " + vPos[0] + " - " + vPos[1] + " - " + vPos[2]);
                Debug.Log("3");
                collision.transform.position = vPos[1];
            }


        }
    }
}
