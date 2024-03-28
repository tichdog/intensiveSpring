using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePointBtn : MonoBehaviour
{
    public LineRenderer line;

    public void Start()
    {
        //line = GetComponent<LineRenderer>();
        /*line.startWidth = 1.2f;
        line.endWidth = 1.2f;*/
        line.positionCount = 0; // Обнуляем точки
    }

    public void _click(GameObject obj)
    {
        // achivOneStep.transform.Find("on").gameObject.SetActive(true);
        Vector2 temp;
        temp.x = obj.transform.position.x;
        temp.y = obj.transform.position.y;
        Debug.Log(temp.x + " vector " + temp.y);
        line.positionCount++;
        Debug.Log(line.positionCount + " positionCNT");
        line.SetPosition(line.positionCount - 1, temp);
    }
}
