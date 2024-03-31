using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject panelLvlSelection;
    public GameObject panelMenu;

    public Animator animator;

    public void Start()
    {
        
        panelLvlSelection.SetActive(false);
        /*panelLvlSelection.gameObject.GetComponent<RectTransform>().localScale = new Vector3(0,0,0);*/
        //_backToMenu();
    }
 
    public void _startTheGame()
    {
        animator.Play("menu");

        /*panelMenu.SetActive(false);
        panelLvlSelection.SetActive(true);*/
        // Debug.Log("Переход на панель выбора уровня");
    }

    public void _backToMenu()
    {
        animator.Play("lvl");

        /*panelMenu.SetActive(true);
        panelLvlSelection.SetActive(false);*/
        // Debug.Log("Переход на панель меню");
    }

}
