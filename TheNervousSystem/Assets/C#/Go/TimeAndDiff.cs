using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndDiff : MonoBehaviour
{
    public Text textTime;
    public GameObject failPanel;
    public GameObject player;

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
            maxTime = time = 60f;
        }
        else
        {
            maxTime = time = 45f;
        }

        failPanel.SetActive(false);
        textTime.text = "���������� �����: " + time.ToString();
    }

    public void Update()
    {
        if( flag)
        {
            time -= Time.deltaTime;
            textTime.text = "���������� �����: " + Mathf.Round(time).ToString();

            if(time <= 0.2f)
            {
                Road.speed = 0;
                player.SetActive(false);
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
