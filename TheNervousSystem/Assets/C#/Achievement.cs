using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievement : MonoBehaviour
{
    public GameObject info;

    public GameObject records;

    public GameObject panelAchivment;
    public Animator animator;

    public GameObject[] objOFF;

    public int lvl1 = 0;
    public int lvl2 = 0;
    public int lvl3 = 0;
    public int lvl4 = 0;
    public int lvl5 = 0;
    // 0 - не пройден 1 - пройден на сложности просто 2 - пройден на харде 
    public GameObject achivOneStep; // 1 балл и более
    public GameObject achivMaster; // 5 баллов и более 
    public GameObject achivHard; // 10 баллов

    // Рекорды
    public Text maze_1;
    public Text maze_2;
    public Text maze_3;

    public Text puzzle_1;
    public Text puzzle_2;
    public Text puzzle_3;

    public Text go_1;
    public Text go_2;
    public Text go_3;

    public void Start()
    {
        def();
        panelAchivment.SetActive(false);
        _infoClose();
        _recordClose();
        Debug.Log("Start Achivment " + PlayerPrefs.GetInt("MMS"));

        if (PlayerPrefs.GetInt("MMS") == 1)
        {
            _achiv();
        }

        if(PlayerPrefs.GetInt("lvl1") != 0) { lvl1 = PlayerPrefs.GetInt("lvl1"); }
        if (PlayerPrefs.GetInt("lvl2") != 0) { lvl2 = PlayerPrefs.GetInt("lvl2"); }
        if (PlayerPrefs.GetInt("lvl3") != 0) { lvl3 = PlayerPrefs.GetInt("lvl3"); }
        if (PlayerPrefs.GetInt("lvl4") != 0) { lvl4 = PlayerPrefs.GetInt("lvl4"); }
        if (PlayerPrefs.GetInt("lvl5") != 0) { lvl5 = PlayerPrefs.GetInt("lvl5"); }
    }

    public void _resetProgress()
    {
        lvl1 = 0;
        PlayerPrefs.SetInt("lvl1", lvl1);
        lvl2 = 0;
        PlayerPrefs.SetInt("lvl2", lvl2);
        lvl3 = 0;
        PlayerPrefs.SetInt("lvl3", lvl3);
        lvl4 = 0;
        PlayerPrefs.SetInt("lvl4", lvl4);
        lvl5 = 0;
        PlayerPrefs.SetInt("lvl5", lvl5);
        animator.Play("close");
        Invoke("objOn", 0.3f);
    }
    
    public void _achiv()
    {
        foreach (GameObject obj in objOFF)
        {
            obj.SetActive(false);
        }

        animator.Play("open");

        sumCheck();     
    }

    public void Update()
    {
        if(panelAchivment.activeSelf == true)
        {
            sumCheck();
        }
    }

    public void sumCheck()
    {
        if(sum() >= 1)
        {
            achivOneStep.transform.Find("on").gameObject.SetActive(true);
            achivOneStep.transform.Find("off").gameObject.SetActive(false);
        }
        else
        {
            achivOneStep.transform.Find("on").gameObject.SetActive(false);
            achivOneStep.transform.Find("off").gameObject.SetActive(true);
        }

        if(sum() >= 5)
        {
            achivMaster.transform.Find("on").gameObject.SetActive(true);
            achivMaster.transform.Find("off").gameObject.SetActive(false);
        }
        else
        {
            achivMaster.transform.Find("off").gameObject.SetActive(true);
            achivMaster.transform.Find("on").gameObject.SetActive(false);
        }

        if(sum() == 10)
        {
            achivHard.transform.Find("on").gameObject.SetActive(true);
            achivHard.transform.Find("off").gameObject.SetActive(false);
        }
        else
        {
            achivHard.transform.Find("off").gameObject.SetActive(true);
            achivHard.transform.Find("on").gameObject.SetActive(false);
        }
    }

    public void _close()
    {
        animator.Play("close");
        Invoke("objOn", 0.3f);
        PlayerPrefs.SetInt("MMS", 0);
    }

    public void _infoOpen()
    {
        info.SetActive(true);
    }

    public void _infoClose()
    {
        info.SetActive(false);
    }

    public void _recordOpen()
    {
        records.SetActive(true);

        if(PlayerPrefs.GetInt(RecordsMiniGame.maze) == int.MaxValue)
        {
            maze_1.text = "...";
        }
        else
        {
            maze_1.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.maze);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.maze_2) == int.MaxValue)
        {
            maze_2.text = "...";
        }
        else
        {
            maze_2.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.maze_2);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.maze_3) == int.MaxValue)
        {
            maze_3.text = "...";
        }
        else
        {
            maze_3.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.maze_3);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.puzzle) == int.MaxValue)
        {
            puzzle_1.text = "...";
        }
        else
        {
            puzzle_1.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.puzzle);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2) == int.MaxValue)
        {
            puzzle_2.text = "...";
        }
        else
        {
            puzzle_2.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.puzzle_2);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.puzzle_3) == int.MaxValue)
        {
            puzzle_3.text = "...";
        }
        else
        {
            puzzle_3.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.puzzle_3);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.go) == 100)
        {
            go_1.text = "...";
        }
        else
        {
            go_1.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.go);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.go_2) == 100)
        {
            go_2.text = "...";
        }
        else
        {
            go_2.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.go_2);
        }

        if (PlayerPrefs.GetInt(RecordsMiniGame.go_3) == 100)
        {
            go_3.text = "...";
        }
        else
        {
            go_3.text = "" + PlayerPrefs.GetInt(RecordsMiniGame.go_3);
        }

    }

    public void _recordClose()
    {
        records.SetActive(false);
    }

    private int sum()
    {
        return lvl1 + lvl2 + lvl3 + lvl4 + lvl5;
    }

    private void objOn()
    {
        foreach (GameObject obj in objOFF)
        {
            obj.SetActive(true);
        }
        def();
    }

    private void def()
    {
        animator.Play("defoult");
    }

    public void _ResetRecords()
    {
        PlayerPrefs.SetInt(RecordsMiniGame.maze, int.MaxValue);
        PlayerPrefs.SetInt(RecordsMiniGame.puzzle, int.MaxValue);
        PlayerPrefs.SetInt(RecordsMiniGame.go, 100);

        PlayerPrefs.SetInt(RecordsMiniGame.maze_2, int.MaxValue);
        PlayerPrefs.SetInt(RecordsMiniGame.puzzle_2, int.MaxValue);
        PlayerPrefs.SetInt(RecordsMiniGame.go_2, 100);

        PlayerPrefs.SetInt(RecordsMiniGame.maze_3, int.MaxValue);
        PlayerPrefs.SetInt(RecordsMiniGame.puzzle_3, int.MaxValue);
        PlayerPrefs.SetInt(RecordsMiniGame.go_3, 100);

        _recordClose();
    }
}
