using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public Animator animator;

    public void _open()
    {
        animator.Play("open");
    }

    public void _close()
    {
        animator.Play("close");
    }
}
