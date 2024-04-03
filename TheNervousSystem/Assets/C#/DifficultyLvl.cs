using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLvl : MonoBehaviour
{
    private int temp = 0;
    public GameObject BtnText;
    bool flag;
    // false ������� true �������

    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") != 0)
        {
            temp = PlayerPrefs.GetInt("diff");
            BtnText.GetComponent<Text>().text = "�������";
            flag = true;
        }
        else
        {
            temp = 0;
            PlayerPrefs.SetInt("diff", 0);
            BtnText.GetComponent<Text>().text = "�������";
            flag = false;
        }
    }

    public void _selectDiff()
    {
        if(flag == false)
        {
            PlayerPrefs.SetInt("diff", 1);
            BtnText.GetComponent<Text>().text = "�������";
            flag = true;
            return;
        }

        if (flag == true)
        {
            PlayerPrefs.SetInt("diff", 0);
            BtnText.GetComponent<Text>().text = "�������";
            flag = false;
            return;

        }
    }
}
