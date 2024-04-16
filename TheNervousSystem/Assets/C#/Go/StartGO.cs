using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGO : MonoBehaviour
{
    public GameObject paneLStartGame;
    public GameObject player;

    public void Awake()
    {
        player.SetActive(false);
        Time.timeScale = 0f;
        paneLStartGame.SetActive(true);
    }

    public void _close()
    {
        player.SetActive(true);
        Time.timeScale = 1f;
        paneLStartGame.SetActive(false);
    }

}
