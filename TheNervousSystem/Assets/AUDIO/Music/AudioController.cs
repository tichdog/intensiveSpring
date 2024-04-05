using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioMixerGroup mixer;
    public GameObject musicObj;


    public void Start()
    {
        musicObj.transform.Find("MusicVolume").GetComponent<Slider>().value = PlayerPrefs.GetFloat("music", 1);
        musicObj.transform.Find("VoiceVolume").GetComponent<Slider>().value = PlayerPrefs.GetFloat("voice", 1);
        _ChangeVolumeMusic(PlayerPrefs.GetFloat("music", 1));
        _ChangeVolumeVoice(PlayerPrefs.GetFloat("voice", 1));
        
    }

    public void _ChangeVolumeMusic(float volume)
    {
        mixer.audioMixer.SetFloat("MusicVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("music", volume);
        
    }

    public void _ChangeVolumeVoice(float volume)
    {
        mixer.audioMixer.SetFloat("VoiceVolume", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("voice", volume);
    }

}
