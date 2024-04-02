using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public GameObject helpPanel;
    private bool flag;
    public Animator anim;
    public void Start()
    {
        helpPanel.SetActive(false);
        flag = false;
    }

    public void _help()
    {
        if(flag == false)
        {
            anim.Play("open");
            flag = true;
            return;
        }

        if(flag == true)
        {
            anim.Play("close");
            flag = false;
            return;
        }
    }
    public void _backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void _restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
