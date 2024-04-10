using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingElement : MonoBehaviour
{
    bool move;
    Vector2 defoultVector; // Что бы возвращать объект на место
    Vector2 mousePos;
    float startPosX;
    float startPosY;
    private float inaccuracy = 200f;
    bool finish;

    // ---- PUBLIC ----
    public GameObject form;
    public Animator animator; // Для харда в котом 2 анимации elem (подсветка) & stop (пустая)

    private void Start()
    {
        defoultVector = transform.position;
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale > 0 && finish == false)
        {
            Debug.Log("Element moving");
            animator.Play("Elem");
            move = true;
            mousePos = Input.mousePosition;

            startPosX = mousePos.x - transform.localPosition.x;
            startPosY = mousePos.y - transform.localPosition.y;
        }
    }

    // когда отпустили кнопку мыши
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
        else
        {
            if(finish == false)
            {
                transform.position = defoultVector;
            }
            
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
