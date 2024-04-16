using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerPuzzle : MonoBehaviour
{
    public float time = 0f;
    public Text text;

    private bool flag;
    public void Start()
    {
        flag = true;
        text.text = "Время прохождения: " + Mathf.Round(time).ToString();
    }
    public void Update()
    {
        if (flag)
        {
            time += Time.deltaTime;
            text.text = "Время прохождения: " + Mathf.Round(time).ToString();
        }

    }

    public int timeLvl()
    {
        return (int)Mathf.Round(time);
    }

    public void stopTime()
    {
        flag = false;
    }
}
