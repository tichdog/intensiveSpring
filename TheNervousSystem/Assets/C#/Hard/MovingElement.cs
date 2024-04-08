using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingElement : MonoBehaviour
{
    bool move;
    Vector2 mousePos;
    float startPosX;
    float startPosY;
    public GameObject form;
    private float inaccuracy = 200f;
    bool finish;
    public Animator animator; // Для харда в котом 2 анимации elem (подсветка) & stop (пустая)

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale > 0)
        {
            Debug.Log("Element moving");
            animator.Play("Elem");
            move = true;
            mousePos = Input.mousePosition;

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
        }
    }

    void OnMouseUp()
    {
        move = false;
        animator.Play("stop");
        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= inaccuracy &&
           Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= inaccuracy && finish != true)
        {
            this.transform.position = new Vector2(form.transform.position.x, form.transform.position.y);
            finish = true;
            WinHard.AddElement();
        }
    }
    void Update()
    {
        if (move == true && finish == false)
        {
            mousePos = Input.mousePosition;
            this.gameObject.transform.localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }
}
