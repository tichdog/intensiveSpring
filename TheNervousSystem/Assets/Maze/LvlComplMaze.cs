using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlComplMaze : MonoBehaviour
{
    public TimarMaze timer;
    public Text recordText;
    public Text textLvl;

    public GameObject winPanel;
    public GameObject[] OFF;

    private int time;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            timer.stopTime();
            record();
            winPanel.SetActive(true);
            off();
        }
    }

    private void off()
    {
        foreach(GameObject i  in OFF)
        {
            i.SetActive(false);
        }

        GameObject[] obj = GameObject.FindGameObjectsWithTag("cell");

        foreach(GameObject i in obj)
        {
            Destroy(i);
        }
    }

    private void record()
    {
        int l1;
        int l2;

        time = timer.timeLvl();
        textLvl.text = "Время прохождения: " + time;

        if (time < PlayerPrefs.GetInt(RecordsMiniGame.maze))
        {
            l1 = PlayerPrefs.GetInt(RecordsMiniGame.maze);
            l2 = PlayerPrefs.GetInt(RecordsMiniGame.maze_2);

            PlayerPrefs.SetInt(RecordsMiniGame.maze, time);
            recordText.text = "Новый рекорд!";

            PlayerPrefs.SetInt(RecordsMiniGame.maze_2, l1);
            PlayerPrefs.SetInt(RecordsMiniGame.maze_3, l2);
        }
        else if (time < PlayerPrefs.GetInt(RecordsMiniGame.maze_2))
        {
            l1 = PlayerPrefs.GetInt(RecordsMiniGame.maze_2);

            PlayerPrefs.SetInt(RecordsMiniGame.maze_2, time);
            recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.maze);

            PlayerPrefs.SetInt(RecordsMiniGame.maze_3, l1);
        }
        else if (time < PlayerPrefs.GetInt(RecordsMiniGame.maze_3))
        {
            PlayerPrefs.SetInt(RecordsMiniGame.maze_3, time);
            recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.maze);
        }
        else
        {
            recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.maze);
        }

    }
}
