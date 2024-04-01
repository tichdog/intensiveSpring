using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioController1 : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource _audio_;
    void Start()
    {
        if (!PlayerPrefs.HasKey("value")) _audio_.volume = 1;
    }

    // Update is called once per frame
    void Update()
    {
        _audio_.volume = PlayerPrefs.GetFloat("value");
    }
}
