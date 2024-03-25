using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomFact : MonoBehaviour
{
    public Text output;
    public string[] fact;
    int temp;

    void Start()
    {
        temp = Random.Range(0, fact.Length);
        output.text = "" + fact[temp];        
    }

    public void _ClickFact()
    {
        int t = Random.Range(0, fact.Length);

        while(t == temp)
        {
            t = Random.Range(0, fact.Length);
        }
       
        output.text = "" + fact[t];
        temp = t;
        
    }
}
