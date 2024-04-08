using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LvlSelect : MonoBehaviour
{
    private int openPanel;
    public GameObject lvlPanel;

    public Animator LVL;

    public GameObject[] objcet;
    public void Start()
    {
        openPanel = PlayerPrefs.GetInt("lp", 0);
        if(openPanel == 0)
        {
            lvlPanel.SetActive(false);
        }
        else
        {
            LVL.Play("back");
            foreach (GameObject j in objcet)
            {
                j.SetActive(true);
            }
            Debug.Log("START LVl SELECT");
        }
    }

    public void _loadLvl(GameObject obj)
    {
        foreach (GameObject j in objcet)
        {
            j.SetActive(true);
        }
        openPanel = 1;
        PlayerPrefs.SetInt("lp", openPanel);

        SceneManager.LoadScene(obj.name);
    }

    public void _Th1()
    {
        foreach (GameObject j in objcet)
        {
            j.SetActive(true);
        }
        openPanel = 1;
        PlayerPrefs.SetInt("lp", openPanel);
        SceneManager.LoadScene("Th1");
    }

    public void _Th2()
    {
        foreach (GameObject j in objcet)
        {
            j.SetActive(true);
        }
        openPanel = 1;
        PlayerPrefs.SetInt("lp", openPanel);
        SceneManager.LoadScene("Th2");
    }

    public void _Th3()
    {
        foreach (GameObject j in objcet)
        {
            j.SetActive(true);
        }
        openPanel = 1;
        PlayerPrefs.SetInt("lp", openPanel);
        SceneManager.LoadScene("Th3");
    }
}
