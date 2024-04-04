using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFX : MonoBehaviour
{
    private AudioSource audio;

    public AudioClip hover;
    public AudioClip pressed;

    public void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void _hoverSound()
    {
        audio.PlayOneShot(hover);
    }

    public void _pressedSound()
    {
        audio.PlayOneShot(pressed);
    }

    public void _stop()
    {

    }
}
