using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    public GameObject show;

    private void Start()
    {
        show.SetActive(false);
    }

    public void OnMouseOver()
    {
        show.SetActive(true);
    }

    public void OnMouseExit()
    {
        show.SetActive(false);
    }
}
