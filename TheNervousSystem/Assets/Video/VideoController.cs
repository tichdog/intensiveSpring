using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public GameObject video;
    private VideoPlayer player;
    private float volume;
    public void Start()
    {
        player = video.GetComponent<VideoPlayer>();
        volume = PlayerPrefs.GetFloat("voice");
        player.SetDirectAudioVolume(0, volume);
    }
}
