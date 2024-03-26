using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlPanel : MonoBehaviour
{
    public GameObject panelOne;
    public GameObject panelTwo;
    private Animation anim;
    /*    public AnimationClip animationOpen;
        public AnimationClip animationClose;*/

    public void Start()
    {
        anim = GetComponent<Animation>();
    }
    public void _lvlPanelOpen()
    {
        panelOne.SetActive(false);
        panelTwo.SetActive(false);

        anim.PlayQueued("open", QueueMode.CompleteOthers);
    }
    
    public void _close()
    {
        anim.PlayQueued("close", QueueMode.CompleteOthers);
        panelOne.SetActive(true);
        panelTwo.SetActive(true);

    }
}
