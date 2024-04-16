using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordsMiniGame : MonoBehaviour
{
    public static string maze = "RecordsMaze";
    public static string maze_2 = "RecordsMaze2";
    public static string maze_3 = "RecordsMaze3";

    public static string puzzle = "RecordsPuzzle";
    public static string puzzle_2 = "RecordsPuzzle2";
    public static string puzzle_3 = "RecordsPuzzle3";

    public static string go = "RecordsGo";
    public static string go_2 = "RecordsGo2";
    public static string go_3 = "RecordsGo3";


    public void Start()
    {
        if (PlayerPrefs.GetInt(maze, 0) == 0)
        {
            PlayerPrefs.SetInt(maze, int.MaxValue);
        }

        if (PlayerPrefs.GetInt(puzzle, 0) == 0)
        {
            PlayerPrefs.SetInt(puzzle, int.MaxValue);
        }

        if (PlayerPrefs.GetInt(go, 0) == 0)
        {
            PlayerPrefs.SetInt(go, 100);
        }

        if (PlayerPrefs.GetInt(maze_2, 0) == 0)
        {
            PlayerPrefs.SetInt(maze_2, int.MaxValue);
        }

        if (PlayerPrefs.GetInt(puzzle_2, 0) == 0)
        {
            PlayerPrefs.SetInt(puzzle_2, int.MaxValue);
        }

        if (PlayerPrefs.GetInt(go_2, 0) == 0)
        {
            PlayerPrefs.SetInt(go_2, 100);
        }

        if (PlayerPrefs.GetInt(maze_3, 0) == 0)
        {
            PlayerPrefs.SetInt(maze_3, int.MaxValue);
        }

        if (PlayerPrefs.GetInt(puzzle_3, 0) == 0)
        {
            PlayerPrefs.SetInt(puzzle_3, int.MaxValue);
        }

        if (PlayerPrefs.GetInt(go_3, 0) == 0)
        {
            PlayerPrefs.SetInt(go_3, 100);
        }
    }

}
