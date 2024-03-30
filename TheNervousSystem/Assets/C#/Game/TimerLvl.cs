using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerLvl : MonoBehaviour
{
    public float time = 30;

    public Text text;

    public void Start()
    {
        text.text = "���������� �����: " +  time.ToString();
    }

    public void Update()
    {
        time -= Time.deltaTime;
        text.text = "���������� �����: " + Mathf.Round(time).ToString();
    }
}