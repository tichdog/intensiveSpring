using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeLvlContrller : MonoBehaviour
{
    public void Reload()
    {
        SceneManager.LoadScene("Maze");
    }
    
    public void _menu()
    {
        PlayerPrefs.SetInt("MMS", 1);
        SceneManager.LoadScene("Menu");
    }
}
