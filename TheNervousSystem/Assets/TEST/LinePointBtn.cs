using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LinePointBtn : MonoBehaviour
{
    public int count = 0;
    public float startWidth = 1.0f;
    public float endWidth = 1.0f;
    public List<int> point;

    private LineRenderer line;
    private bool flag = true;
    public void Start()
    {
        line = GetComponent<LineRenderer>();
        line.startWidth = startWidth;
        line.endWidth = endWidth;
        line.positionCount = 0; // Обнуляем точки
    }

    public void _click(GameObject obj)
    {
        if(point.IndexOf(int.Parse(obj.name)) == -1)
        {
            Vector3 temp;
            // Button position
            temp.x = obj.transform.position.x;
            temp.y = obj.transform.position.y;
            temp.z = 1;

            // add number button to list
            point.Add(int.Parse(obj.name));

            line.positionCount++;
            line.SetPosition(line.positionCount - 1, temp);
        
            Debug.Log(line.positionCount + " positionCNT");
            Debug.Log(temp.x + " vector " + temp.y);
        }
        else
        {
            Debug.Log("Element copy");
        }

        if(point.Count == count)
        {
            for(int i = 0;  i < point.Count - 1; i++)
            {
                if (point[i] > point[i + 1])
                {
                    flag = false;
                    _resetPoint();
                    break;
                }
            }

            if (flag)
            {
                Debug.Log("Уровень пройден");
            }
            else
            {
                Debug.Log("ТЫ еблан");
            }
        }
    }

    public void _resetPoint()
    {
        point.Clear();
        line.positionCount = 0;
    }
}
