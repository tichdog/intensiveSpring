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

    public GameObject[] HardOff; // ����� ��������� �� �����
    public GameObject[] SoftOff; // ����� ��������� �� ������
    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") == 0)
        {
            // �������
            helpBtn.SetActive(true);
            Timer.SetActive(false);

            foreach(GameObject obj in SoftOff)
            {
                obj.SetActive(false);
            }
        }
        else
        {
            // �������
            VoiceOBJ.transform.position = helpBtn.transform.position;
            Timer.SetActive(true);
            helpBtn.SetActive(false);

            foreach (GameObject obj in HardOff)
            {
                obj.SetActive(false);
            }
        }

        

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
