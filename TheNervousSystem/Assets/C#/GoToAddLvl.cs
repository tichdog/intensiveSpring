using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAddLvl : MonoBehaviour
{

    public void _Puzzle()
    {
        SceneManager.LoadScene("Puzzle");
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
