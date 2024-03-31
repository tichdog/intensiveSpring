using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public bool lvlComplit = false;
    public Vector2 v;
    public float speed = 0f;
    public void Start()
    {
        v = transform.position;
        Debug.Log("pos " + v.x + " " + v.y);
    }

    public void FixedUpdate()
    {
        if (lvlComplit)
        {
            v.x += speed;
            transform.position = v;
        }
        
    }
}
