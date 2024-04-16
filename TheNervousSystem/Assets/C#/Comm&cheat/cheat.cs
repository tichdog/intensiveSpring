using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheat : MonoBehaviour
{
    public void _cheat()
    {
        PlayerPrefs.SetInt("lvl1", 2);
        PlayerPrefs.SetInt("lvl2", 2);
        PlayerPrefs.SetInt("lvl3", 2);
        PlayerPrefs.SetInt("lvl4", 2);
        PlayerPrefs.SetInt("lvl5", 2);
    }
}
