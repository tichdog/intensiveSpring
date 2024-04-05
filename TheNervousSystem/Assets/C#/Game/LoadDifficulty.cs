using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDifficulty : MonoBehaviour
{
    public GameObject helpBtn;
    public GameObject Timer;
    public GameObject VoiceOBJ;
    public GameObject helpPanel;
    private bool flag;
    public Animator anim;

    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") == 0)
        {
            helpBtn.SetActive(true);
            Timer.SetActive(false);
        }
        else
        {
            Timer.SetActive(true);
            helpBtn.SetActive(false);
        }

        VoiceOBJ.transform.position = helpBtn.transform.position;

        helpPanel.SetActive(false);
        flag = false;
    }
    public void _help()
    {
        if (flag == false)
        {
            anim.Play("open");
            flag = true;
            return;
        }

        if (flag == true)
        {
            anim.Play("close");
            flag = false;
            return;
        }
    }
}
