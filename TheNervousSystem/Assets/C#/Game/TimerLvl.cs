using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLvl : MonoBehaviour
{
    public float time = 30;

    public Text text;
    public GameObject failPanel;


    public void Start()
    {
        failPanel.SetActive(false);
        text.text = "Оставшееся время: " +  time.ToString();
    }

    public void Update()
    {
        time -= Time.deltaTime;
        text.text = "Оставшееся время: " + Mathf.Round(time).ToString();
        if(time < 0.5)
        {
            failPanel.SetActive(true);
        }
    }
}
