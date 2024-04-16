using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comics : MonoBehaviour
{
    public Animator animator;
    public GameObject[] lists;

    private int t;
    public void Start()
    {
        t = 0;
        foreach (GameObject i in lists)
        {
            i.SetActive(false);
        }
    }

    public void _right()
    {
        if(t < lists.Length - 1)
        {
            t++;
            lists[t].SetActive(true);         
        }
    }

    public void _left()
    {
       if(t != 0)
       {
            lists[t].SetActive(false);
            t--;    
       }
    }
    public void _open()
    {
        animator.Play("open");
        lists[t].SetActive(true);
    }

    public void _close()
    {
        animator.Play("close");
    }
}
