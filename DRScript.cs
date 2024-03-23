using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionSystem : MonoBehaviour
{
    public List<GameObject> buttons; // список всех кнопок на сцене
    public LineRenderer lineRenderer; // префаб линии
    private List<GameObject> connectedButtons; // список связанных кнопок
    private bool check = false;

    void Start()
    {
        connectedButtons = new List<GameObject>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject button = hit.collider.gameObject;
                if (button.CompareTag("Button"))
                {
                    if (connectedButtons.Count < 2)
                    {
                        if (connectedButtons.Count == 1 && connectedButtons[0] == button)
                        {
                            connectedButtons.RemoveAt(0);
                            lineRenderer.SetPosition(1, button.transform.position);
                            lineRenderer.enabled = false;
                        }
                        else if (!connectedButtons.Contains(button))
                        {
                            connectedButtons.Add(button);

                            if (connectedButtons.Count == 1)
                            {
                                lineRenderer.SetPosition(0, button.transform.position);
                                lineRenderer.enabled = true;
                            }
                            else
                            {
                                lineRenderer.SetPosition(1, button.transform.position);
                                lineRenderer.enabled = true;
                                _CheckConnections();
                            }
                        }
                    }
                }
            }
        }
    }

    void _CheckConnections()
    {
        List<GameObject> correctOrder = new List<GameObject>();   
        if (connectedButtons.Count == correctOrder.Count)
        {
            bool correct = true;
            for (int i = 0; i < connectedButtons.Count; i++)
            {
                if (connectedButtons[i] != correctOrder[i])
                {
                    correct = false;
                    break;
                }
            }

            if (correct)
            {
                check = true;
            }
            else
            {
                connectedButtons.Clear();
                lineRenderer.enabled = false;
            }
        }
    }
}
