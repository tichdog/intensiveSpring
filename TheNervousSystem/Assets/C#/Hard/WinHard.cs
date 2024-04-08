using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHard : MonoBehaviour
{
    int fullElement;//���-�� ���� ��������� �����
    public static int myElement;//����� ���������, ������� �� ����� �����
    public GameObject myPuzzl;//������������ ������, ���������� ��� �������� ����� 

    public static bool finish;
    void Start()
    {
        finish = false;
        Remove();
        fullElement = myPuzzl.transform.childCount;//�������� ���-�� ��������� �����
    }

    void Update()
    {
        if (fullElement == myElement)
        {//���� ��� �������� �� ����� �����
            finish = true;
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
}
