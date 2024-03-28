using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyLvl : MonoBehaviour
{
    private int temp = 0;
    public Dropdown dropdown;


    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") != 0)
        {
            temp = PlayerPrefs.GetInt("diff");
            dropdown.value = temp;
        }
        else
        {
            temp = 0;
            PlayerPrefs.SetInt("diff", 0);
            dropdown.value = temp;
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
