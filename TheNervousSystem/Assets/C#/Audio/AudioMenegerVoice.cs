using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AudioMenegerVoice : MonoBehaviour
{
    public GameObject btnPlay;
    public GameObject btnPause;

    public AudioSource audio;
    public AudioClip[] clips;

    private bool isPlay = false;
    private int temp;
    public void Start()
    {
        btnPause.SetActive(false);
        btnPlay.SetActive(true);
        temp = 0;
    }   


}
