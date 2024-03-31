using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject closePanel;
    public Animator animator;
    public void Start()
    {
        closePanel.SetActive(false);
    }

    public void _openClose()
    {
        animator.Play("open");
    }

    public void _closeClose()
    {
        animator.Play("close");
    }

    public void _exit()
    {
        Application.Quit();
        // Debug.Log("exit");
    }
}
