using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Knot : MonoBehaviour
{

    public Text textKnot;
    private bool flag;
    public void Start()
    {
        flag = true;
        textKnot.text = "";
    }

    public void _open(string text)
    {
        if(flag)
        {
            textKnot.text = text;
            flag = false;
        }
        else
        {
            textKnot.text = "";
            flag = true;
        }
       
    }


}
