using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryGo : MonoBehaviour
{
    public TimeAndDiff timeAndDiff;

    public GameObject victoryPanel;
    public Text textTime;

    public Text recordText;

    public GameObject player;
    public void Start()
    {
        victoryPanel.SetActive(false);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            int l1;
            int l2;

            Debug.Log("Victory");
            // Останавливаем время и читаем время прохождения
            timeAndDiff.stopTime();
            int temp = timeAndDiff.timeLvl();

            player.SetActive(false);

            victoryPanel.SetActive(true);
            textTime.text = "Время прохождения: " + temp + " сек";
            
            // Новый рекорд

            if(temp <= PlayerPrefs.GetInt(RecordsMiniGame.go))
            {
                l1 = PlayerPrefs.GetInt(RecordsMiniGame.go);
                l2 = PlayerPrefs.GetInt(RecordsMiniGame.go_2);

                PlayerPrefs.SetInt(RecordsMiniGame.go, temp);
                recordText.text = "Новый рекорд!";

                PlayerPrefs.SetInt(RecordsMiniGame.go_2, l1);
                PlayerPrefs.SetInt(RecordsMiniGame.go_3, l2);
            }
            else if(temp < PlayerPrefs.GetInt(RecordsMiniGame.go_2))
            {
                l1 = PlayerPrefs.GetInt(RecordsMiniGame.go_2);

                PlayerPrefs.SetInt(RecordsMiniGame.go_2, temp);
                recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.go);

                PlayerPrefs.SetInt(RecordsMiniGame.go_3, l1);
            }
            else if (temp < PlayerPrefs.GetInt(RecordsMiniGame.go_3))
            {
                PlayerPrefs.SetInt(RecordsMiniGame.go_3, temp);
                recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.go);
            }
            else
            {
                recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.go);
            }

        }
    }
}
