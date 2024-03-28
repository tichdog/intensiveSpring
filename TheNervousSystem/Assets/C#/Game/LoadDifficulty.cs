using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadDifficulty : MonoBehaviour
{
    public GameObject helpBtn;
    
    public void Start()
    {
        if(PlayerPrefs.GetInt("diff") == 0)
        {
            helpBtn.SetActive(true);
        }
        else
        {
            helpBtn.SetActive(false);
        }
    }
}
