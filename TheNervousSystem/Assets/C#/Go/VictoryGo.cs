using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryGo : MonoBehaviour
{
    public TimeAndDiff timeAndDiff;

    public GameObject victoryPanel;
    public Text textTime;

    public void Start()
    {
        victoryPanel.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            timeAndDiff.stopTime();
            int temp = timeAndDiff.timeLvl();
            victoryPanel.SetActive(true);
            textTime.text = "Время прохождения: " + temp;
            
            if(timeAndDiff.timeLvl() < PlayerPrefs.GetInt(RecordsMiniGame.go))
            {
                PlayerPrefs.SetInt(RecordsMiniGame.go, temp);
            }

        }
    }
}
