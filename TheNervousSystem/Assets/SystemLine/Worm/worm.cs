using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TerrainTools;

public class worm : MonoBehaviour
{
    private LineRenderer line;
    static Vector3 one = Vector3.zero;
    static Vector3 two = Vector3.zero;
    public void Start()
    {
        line = GetComponent<LineRenderer>();
        line.startWidth = 0.2f;
        line.endWidth = 0.2f;
        line.positionCount = 0; // Обнуляем точки

        one = WormLine.coordinateOne();
        two = WormLine.coordinateTwo();

        paint();

    }

    public void paint()
    {
        line.positionCount++;
        line.SetPosition(line.positionCount - 1, one);
        line.positionCount++;
        line.SetPosition(line.positionCount - 1, two);
    }
}
