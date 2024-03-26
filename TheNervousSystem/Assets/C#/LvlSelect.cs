using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelect : MonoBehaviour
{
    public void _loadLvl(GameObject obj)
    {
        SceneManager.LoadScene(obj.name);
    }
}
