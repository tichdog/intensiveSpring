using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour
{
    int fullElement;//���-�� ���� ��������� �����
    public static int myElement;//����� ���������, ������� �� ����� �����
    public GameObject myPuzzl;//������������ ������, ���������� ��� �������� ����� 
    public GameObject myPanel;//������ � ������
    public GameObject winPanel;//������ ������


    public TimerPuzzle timer;
    public Text recordText;
    public Text textLvl;

    private int time;
    private bool flag;
    void Start()
    {
        flag = false;
        winPanel.SetActive(false);
        fullElement = myPuzzl.transform.childCount;//�������� ���-�� ��������� �����
    }

    void Update()
    {
        if (fullElement == myElement && flag == false)
        {//���� ��� �������� �� ����� �����
            myPanel.SetActive(false);//�������� ������ � ������

            record();
            flag = true;
            winPanel.SetActive(true);//���������� ������ ������
        }
    }

    //������� ���������� ���-�� ���������, ������� ����� �� ����� �����
    public static void AddElement()
    {
        myElement++;//�����������
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
        textLvl.text = "����� �����������: " + time;

        if (time <= PlayerPrefs.GetInt(RecordsMiniGame.puzzle))
        {
            l1 = PlayerPrefs.GetInt(RecordsMiniGame.puzzle);
            l2 = PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2);

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle, time);
            recordText.text = "����� ������!";

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_2, l1);
            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_3, l2);
        }
        else if (time < PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2))
        {
            l1 = PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2);

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_2, time);
            recordText.text = "������: " + PlayerPrefs.GetInt(RecordsMiniGame.puzzle);

            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_3, l1);
        }
        else if (time < PlayerPrefs.GetInt(RecordsMiniGame.puzzle_3))
        {
            PlayerPrefs.SetInt(RecordsMiniGame.puzzle_3, time);
            recordText.text = "������: " + PlayerPrefs.GetInt(RecordsMiniGame.puzzle);
        }
        else
        {
            recordText.text = "������: " + PlayerPrefs.GetInt(RecordsMiniGame.puzzle);
        }

    }
}
