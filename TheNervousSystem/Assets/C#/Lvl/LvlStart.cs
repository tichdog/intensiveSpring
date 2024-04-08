using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlStart : MonoBehaviour
{

    public GameObject Panel;

    public GameObject easyText;
    public GameObject hardText;

    public void Awake()
    {
        Time.timeScale = 0f;
    }
    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") == 0)
        {
            easyText.SetActive(true); 
            hardText.SetActive(false);
        }
        else
        {
            easyText.SetActive(false);
            hardText.SetActive(true);
        }

        Panel.SetActive(true);
    }

    public void _close()
    {
        Time.timeScale = 1.0f;
        Panel.SetActive(false);
    }

}
