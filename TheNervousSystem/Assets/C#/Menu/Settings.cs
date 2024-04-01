using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class Settings : MonoBehaviour
{
    public Animator animator;
    public GameObject[] obj;
    public GameObject[] close;
    public float time = 0f;
    public AudioSource source;
    public void _open()
    {
        animator.Play("open");
        objOffOn(true, obj);
        Invoke("off", time);
    }

    public void _close()
    {
        objOffOn(false, obj);
        animator.Play("close");
        Invoke("on", time);
    }

    private void on()
    {
        objOffOn(true, close);
    }

    private void off()
    {
        objOffOn(false, close);
    }
    public void objOffOn(bool b, GameObject[] obj)
    {
        foreach (GameObject i in obj)
        {
            i.SetActive(b);
        }
    }

    public void _anotherSong()
    {
         source.Stop();
    }

}
