using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordsMiniGame : MonoBehaviour
{
    public static string maze = "RecordsMaze";
    public static string puzzle = "RecordsPuzzle";
    public static string go = "RecordsGo";

    public void Start()
    {
        if (PlayerPrefs.GetInt(maze, 0) == 0)
        {
            PlayerPrefs.SetInt(maze, 0);
        }

        if (PlayerPrefs.GetInt(puzzle, 0) == 0)
        {
            PlayerPrefs.SetInt(puzzle, 0);
        }

        if (PlayerPrefs.GetInt(go, 0) == 0)
        {
            PlayerPrefs.SetInt(go, 0);
        }
          
    }

    public void _ResetRecords()
    {
        PlayerPrefs.SetInt(maze, 0);
        PlayerPrefs.SetInt(puzzle, 0);
        PlayerPrefs.SetInt(go, 0);
    }
}
