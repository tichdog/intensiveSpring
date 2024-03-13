using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void _exit()
    {
        Application.Quit();
    }
    
    public void _startTheGame()
    {
        SceneManager.LoadScene("Game");
    }
}
