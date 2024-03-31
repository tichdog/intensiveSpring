using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public Animator animator;
    public GameObject[] obj;

    public void _open()
    {
        animator.Play("open");
        objOffOn(true);
    }

    public void _close()
    {
        objOffOn(false);
        animator.Play("close");
    }

    public void objOffOn(bool b)
    {
        foreach (GameObject i in obj)
        {
            i.SetActive(b);
        }
    }
}
