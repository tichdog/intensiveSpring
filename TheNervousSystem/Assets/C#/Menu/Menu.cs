using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject panelLvlSelection;
    public GameObject panelMenu;

    public void Start()
    {
        _backToMenu();
    }
 
    public void _startTheGame()
    {
        panelMenu.SetActive(false);
        panelLvlSelection.SetActive(true);
        // Debug.Log("Переход на панель выбора уровня");
    }

    public void _backToMenu()
    {
        panelMenu.SetActive(true);
        panelLvlSelection.SetActive(false);
        // Debug.Log("Переход на панель меню");
    }

    public void _exit()
    {
        Application.Quit();
        // Debug.Log("exit");
    }
}
