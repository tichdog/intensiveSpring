using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlPanel : MonoBehaviour
{
    public float speed = 0.85f;
    public GameObject panelOne;
    public GameObject panelTwo;
    private Animator anim;
    public Button button;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void _lvlPanelOpen()
    {

        panelOne.SetActive(false);
        panelTwo.SetActive(false);
        button.interactable = false;
        anim.Play("open");
    }
    
    public void _close()
    {
        anim.Play("close");
        Invoke("open", speed);
        button.interactable = true;
    }

    private void open()
    {
        panelOne.SetActive(true);
        panelTwo.SetActive(true);
    }
}
