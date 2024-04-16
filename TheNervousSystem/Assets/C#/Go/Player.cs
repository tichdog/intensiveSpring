using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject player;

    public GameObject line_1;
    public GameObject line_2;
    public GameObject line_3;

    private int playerLine;

    public void Start()
    {
        playerLine = 2; // position Player line 2 
        player.transform.position = line_2.transform.position;
    }

    public void FixedUpdate()
    {
        if(player.transform.position == line_1.transform.position)
        {
            playerLine = 1;
        }

        if (player.transform.position == line_2.transform.position)
        {
            playerLine = 2;
        }

        if (player.transform.position == line_3.transform.position)
        {
            playerLine = 3;
        }

    }

    public void _playerUp()
    {
        Up();
    }

    private void Up()
    {
        if (playerLine == 1)
        {
            return;
        }

        if (playerLine == 2)
        {
            playerLine = 1;
            player.transform.position = line_1.transform.position;
            return;
        }

        if (playerLine == 3)
        {
            playerLine = 2;
            player.transform.position = line_2.transform.position;
            return;
        }
    }

    private void Down()
    {
        if(playerLine == 3)
        {
            return;
        }

        if(playerLine == 1)
        {
            playerLine = 2;
            player.transform.position = line_2.transform.position;
            return;
        }

        if( playerLine == 2)
        {
            playerLine = 3;
            player.transform.position = line_3.transform.position;
            return;
        }
    }

    public void _playerDown()
    {
        Down();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Up();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Down();
        }
    }
}
