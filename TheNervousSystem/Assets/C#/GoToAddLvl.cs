using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAddLvl : MonoBehaviour
{
    private int AcivmentActiv;

    public void Start()
    {
        AcivmentActiv = PlayerPrefs.GetInt("MMS", 0);
    }

/*    public void GoToAcivmentGame()
    {
        AcivmentActiv = 1;
        PlayerPrefs.SetInt("MMS", AcivmentActiv);
        SceneManager.LoadScene("Maze");
    }*/

    public void _Puzzle()
    {
        AcivmentActiv = 1;
        PlayerPrefs.SetInt("MMS", AcivmentActiv);
        SceneManager.LoadScene("Puzzle");
    }

    public void _Maze()
    {
        AcivmentActiv = 1;
        PlayerPrefs.SetInt("MMS", AcivmentActiv);
        SceneManager.LoadScene("Maze");
    }

    public void _Go()
    {
        AcivmentActiv = 1;
        PlayerPrefs.SetInt("MMS", AcivmentActiv);
        SceneManager.LoadScene("Go");
    }

    public void _Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void _Restart()
    {
        _Puzzle();
        WinScript.Remove();
    }
}
