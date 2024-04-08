using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHard : MonoBehaviour
{
    int fullElement;//Кол-во всех элементов пазла
    public static int myElement;//Число элементов, лежащих на своем месте
    public GameObject myPuzzl;//Родительский объект, содержащий все элементы пазла 

    public static bool finish;
    void Start()
    {
        finish = false;
        Remove();
        fullElement = myPuzzl.transform.childCount;//Получаем кол-во элементов пазла
    }

    void Update()
    {
        if (fullElement == myElement)
        {//Если все элементы на своем месте
            finish = true;
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
}
