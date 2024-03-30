using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDifficulty : MonoBehaviour
{
    public GameObject helpBtn;
    public GameObject Timer;
    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") == 0)
        {
            helpBtn.SetActive(true);
            Timer.SetActive(false);
        }
        else
        {
            Timer.SetActive(true);
            helpBtn.SetActive(false);
        }
    }
}
