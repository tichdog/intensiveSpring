using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlComplMaze : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject[] OFF;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            winPanel.SetActive(true);
            off();
        }
    }

    private void off()
    {
        foreach(GameObject i  in OFF)
        {
            i.SetActive(false);
        }

        GameObject[] obj = GameObject.FindGameObjectsWithTag("cell");

        foreach(GameObject i in obj)
        {
            Destroy(i);
        }
    }
}
