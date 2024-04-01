using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class RandonMusic : MonoBehaviour
{
    private int t;
    public void Awake()
    {
        t = Random.Range(0, clip.Length);
        _rnd(t);
    }

    public AudioSource source;
    public AudioClip[] clip;
    public void _rnd(int temp)
    {
        source.PlayOneShot(clip[temp]);
        
    }

    public void Update()
    {
        if (!source.isPlaying)
        {
            int u = Random.Range(0, clip.Length);
            while(t == u)
            {
                u = Random.Range(0, clip.Length);
            }

            _rnd(u);
            t = u;
        }
    }
}
