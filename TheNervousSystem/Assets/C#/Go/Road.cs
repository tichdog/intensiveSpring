using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public static float speed = -0.4f;

    private Vector2 dir;
    public GameObject roadObj;

    public void Start()
    {
        dir = new Vector2(speed, 0);
    }
    public void FixedUpdate()
    {
        dir = new Vector2(speed, 0);
        roadObj.transform.Translate(dir);
    }
}
