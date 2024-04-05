using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FactController : MonoBehaviour
{
    public AudioSource audio;

    public Button button;

    public Sprite play;
    public Sprite pause;

    private bool flag;
    private float pauseTime;
    // false - off \ true - on
    public void Start()
    {
        pauseTime = 0f;
        flag = false;
        button.GetComponent<Image>().sprite = play;
    }

    public void _btn()
    {
        if (flag)
        {
            _pause();
            return;
        }

        if (!flag)
        {
            _play();
            return;
        }
    }

    private void _play()
    {
        audio.time = pauseTime;
        audio.Play();
        button.GetComponent<Image>().sprite = pause;
        flag = true;
    }

    private void _pause()
    {
        audio.Pause();
        pauseTime = audio.time;
        button.GetComponent<Image>().sprite = play;
        flag = false;
    }


}
