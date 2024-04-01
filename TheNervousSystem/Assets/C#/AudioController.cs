using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio_;
    void Start()
    {
        if (!PlayerPrefs.HasKey("volume")) audio_.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        audio_.volume = PlayerPrefs.GetFloat("volume");
    }
}
