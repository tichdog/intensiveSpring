using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndDiff : MonoBehaviour
{
    public Text textTime;
    public GameObject failPanel;

    private int deff;
    private float maxTime;
    private float time;
    private bool flag;
    public void Start()
    {
        flag = true;
        deff = PlayerPrefs.GetInt("diff", 0);
        if( deff == 0)
        {
            maxTime = time = 40f;
        }
        else
        {
            maxTime = time = 35f;
        }

        failPanel.SetActive(false);
        textTime.text = "Оставшееся время: " + time.ToString();
    }

    public void Update()
    {
        if( flag)
        {
            time -= Time.deltaTime;
            textTime.text = "Оставшееся время: " + Mathf.Round(time).ToString();

            if(time <= 0.2f)
            {
                Road.speed = 0;
                failPanel.SetActive(true);
            }
        }
    }

    public int timeLvl()
    {    
        return (int) Mathf.Round(maxTime - time);
    }

    public void stopTime()
    {
        flag = false;
    }
}
