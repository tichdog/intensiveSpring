using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class btnOptionsGo : MonoBehaviour
{
    public void _restrat()
    {
        //Road.defoultSpeed();
        SceneManager.LoadScene("Go");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
