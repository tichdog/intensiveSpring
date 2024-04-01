using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LinePointBtn : MonoBehaviour
{
    public string nameCreature = "";
    public int count = 0;
    public float startWidth = 1.0f;
    public float endWidth = 1.0f;
    public List<int> point;

    private LineRenderer line;
    private bool flag = true;

    private int id = 0;

    public Vector2 mouse;
    public void Start()
    {
        switch (nameCreature)
        {
            case "worm":
            {
                id = 1;
                break;
            }

            case "grasshopper":
                {
                    id = 2;
                    break;
                }

            case "frog":
                {
                    id = 3;
                    break;
                }

            case "hydra":
                {
                    id = 0;
                    break;
                }

            case "human":
                {
                    id = 4;
                    break;
                }
        }
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
            
        }
        else
        {
            Debug.Log("Element copy");
        }

        if(point.Count == count)
        {
            check();
        }
    }

    private void check()
    {
        if(id == 1 || id == 2)
        {
            for(int i = 0;  i < point.Count - 1; i++)
            {
                Debug.Log(point[i] + " i ");
                if (point[i] > point[i + 1])
                {
                    flag = false;
                    _resetPoint();
                    break;
                }
                else
                {
                    flag = true;
                }
            }
        }
        
        if (flag)
        {
            Debug.Log("Уровень пройден");
        }
        else
        {
            Debug.Log("fail");
        }
    }

    public void _resetPoint()
    {
        point.Clear();
        line.positionCount = 0;
    }
}
