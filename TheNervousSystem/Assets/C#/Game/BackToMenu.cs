using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    
    public void _backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void _restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void _loadScen(string name)
    {
        SceneManager.LoadScene(name);
    }
}
