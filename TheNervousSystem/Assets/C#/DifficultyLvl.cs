using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyLvl : MonoBehaviour
{
    private int temp = 0;

    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") != 0)
        {
            temp = PlayerPrefs.GetInt("diff");
        }
        else
        {
            temp = 0;
            PlayerPrefs.SetInt("diff", 0);
        }
    }

    public void _selectDiff(int value)
    {
        if (value == 0)
        {
            PlayerPrefs.SetInt("diff", 0);
            Debug.Log("Новичок" + PlayerPrefs.GetInt("diff"));
        }

        if(value == 1)
        {
            PlayerPrefs.SetInt("diff", 1);
            Debug.Log("Опытный" + PlayerPrefs.GetInt("diff"));
        }
    }
}
