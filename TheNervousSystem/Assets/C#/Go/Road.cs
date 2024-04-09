using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float speed = 1f;
    private Vector2 dir;
    public GameObject roadObj;

    public void Start()
    {
        dir = new Vector2(speed, 0);
    }
    public void FixedUpdate()
    {
        roadObj.transform.Translate(dir);
    }
}
