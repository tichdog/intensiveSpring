using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelect : MonoBehaviour
{
    public void _loadLvl(GameObject obj)
    {
        SceneManager.LoadScene(obj.name);
    }

    public void _Th1()
    {
        SceneManager.LoadScene("Th1");
    }

    public void _Th2()
    {
        SceneManager.LoadScene("Th2");
    }

    public void _Th3()
    {
        SceneManager.LoadScene("Th3");
    }
}
