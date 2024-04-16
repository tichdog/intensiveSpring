using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    int fullElement;//Кол-во всех элементов пазла
    public static int myElement;//Число элементов, лежащих на своем месте
    public GameObject myPuzzl;//Родительский объект, содержащий все элементы пазла 
    public GameObject myPanel;//Панель с пазлом
    public GameObject winPanel;//Панель победы


    public TimerPuzzle timer;
    public Text recordText;
    public Text textLvl;

    private int time;
    private bool flag;
    void Start()
    {
        flag = false;
        winPanel.SetActive(false);
        fullElement = myPuzzl.transform.childCount;//Получаем кол-во элементов пазла
    }

    void Update()
    {
        if (fullElement == myElement && flag == false)
        {//Если все элементы на своем месте
            myPanel.SetActive(false);//Скрываем панель с пазлом

            record();
            flag = true;
            winPanel.SetActive(true);//Показываем панель победы
        }
    }

    //Функция увеличения кол-ва элементов, которые лежат на своем месте
    public static void AddElement()
    {
        myElement++;//Увеличиваем
    }

    public static void Remove()
    {
        myElement = 0;
    }

    private void record()
    {
        int l1;
        int l2;

        timer.stopTime();

        time = timer.timeLvl();
        textLvl.text = "Время прохождения: " + time;

        if (time <= PlayerPrefs.GetInt(RecordsMiniGame.puzzle))
        {
            l1 = PlayerPrefs.GetInt(RecordsMiniGame.puzzle);
            l2 = PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2);

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle, time);
            recordText.text = "Новый рекорд!";

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_2, l1);
            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_3, l2);
        }
        else if (time < PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2))
        {
            l1 = PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2);

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_2, time);
            recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.puzzle);

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_3, l1);
        }
        else if (time < PlayerPrefs.GetInt(RecordsMiniGame.puzzle_3))
        {
            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_3, time);
            recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.puzzle);
        }
        else
        {
            recordText.text = "Рекорд: " + PlayerPrefs.GetInt(RecordsMiniGame.puzzle);
        }

    }
}
