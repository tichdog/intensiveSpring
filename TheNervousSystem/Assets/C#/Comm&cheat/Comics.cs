using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comics : MonoBehaviour
{
    public GameObject comics;

    public GameObject l1;
    public GameObject l2;
    public GameObject l3;

    private int t;
    public void Start()
    {
        t = 1;
        comics.SetActive(false);

        l1.SetActive(false);
        l2.SetActive(false);
        l3.SetActive(false);
    }

    public void _right()
    {
        if(t == 1)
        {
            t = 2;
            l1.SetActive(false);
            l2.SetActive(true);
        }
        else if(t == 2)
        {
            t = 3;
            l2.SetActive(false);
            l3.SetActive(true);
        }
    }

    public void _left()
    {
        if(t == 3)
        {
            t = 2;
            l3.SetActive(false);
            l2.SetActive(true);
        }
        else if( t == 2)
        {
            t = 1;
            l2.SetActive(false);
            l1.SetActive(true);
        }
    }
    public void _open()
    {
        comics.SetActive (true);
        l1.SetActive(true);
        
    }

    public void _close()
    {
        comics.SetActive (false);
    }
}
