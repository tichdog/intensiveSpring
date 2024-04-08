using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Experimental.GlobalIllumination;

public class GrasshopperLine : MonoBehaviour
{
    // Счетчик для линий
    public int count = 0;

    public List<int> point;

    public GameObject sys;
    public GameObject elem;

    public static Vector3 one;
    public static Vector3 two;

    public bool lvl = false;

    public Animator animator;
    public Animation catAnim;
    public GameObject timePanel;
    public GameObject btn;

    private string key_1 = "12345";

    private bool flag = false;

    public static bool time;

    public GameObject[] OFF;

    public void Start()
    {
        time = true; // true время есть 
        btn.SetActive(false);
    }

    public void off()
    {
        foreach (GameObject i in OFF)
        {
            i.SetActive(false);
        }
    }

    public void _click(GameObject obj)
    {
        string name = obj.name;
        int temp = int.Parse(name);
        point.Add(temp);

        if (!flag)
        {
            one = GetPos(obj);
            flag = true;
        }
        else
        {
            two = GetPos(obj);

            if(one.x == two.x || one.y == two.y)
            {
                flag = false;
                try
                {
                    point.RemoveAt(point.Count - 1);
                    point.RemoveAt(point.Count - 1);
                }
                catch
                {
                    Debug.Log("Fatal ERROR!");
                }
                return;
            }

            sys = Instantiate(elem);
            flag = false;
        }

    }

    private void Update()
    {
        if (point.Count == count && WinHard.finish == true && lvl == false) // finish - на местах ли элементы
        {
            check();
        }

        if (point.Count == count && PlayerPrefs.GetInt("diff") == 0 && lvl == false)
        {
            check();
        }

        if (point.Count > count + 1 || time == false)
        {
            lvl = false;
            _reset();
            Debug.Log("FAIL");
        }
    }

    public void check()
    {
        string s = "";
        int temp = 0;

        foreach(int i in point)
        {
            if(i != temp)
            {
                s += i;
                temp = i;
            }
        }

        Debug.Log(s);

        if(s.IndexOf(key_1) != -1)
        {
            GameObject[] obj;
            obj = GameObject.FindGameObjectsWithTag("point");
            foreach (GameObject i in obj)
            {
                Destroy(i);
            }

            lvl = true;
            timePanel.SetActive(false);   
            
            // Чек ачивки
            if(PlayerPrefs.GetInt("diff") == 0)
            {
                PlayerPrefs.SetInt("lvl2", 1);
            }
            else
            {
                PlayerPrefs.SetInt("lvl2", 2);
            }

            animator.Play("compl");
            Invoke("_btn",0.8f);
            Debug.Log("LVL COMPLETE");
        }
        else
        {
            lvl = false;
            _reset();
            Debug.Log("FAIL");
        }

    }

    public void _btn()
    {
        btn.SetActive(true);
    }

    public static Vector3 coordinateOne()
    {
        return one;
    }

    public static Vector3 coordinateTwo()
    {
        return two;
    }

    public Vector3 GetPos(GameObject obj)
    {
        Vector3 temp;
        // Button position
        temp.x = obj.transform.position.x;
        temp.y = obj.transform.position.y;
        temp.z = 1;

        return temp;
    }
    
    public void _reset()
    {
        catAnim.Play();
        flag = false;
        point.Clear();
        GameObject[] obj;
        obj = GameObject.FindGameObjectsWithTag("point");
        foreach(GameObject i in obj)
        {
            Destroy(i);
        }
    }

    public void _continue()
    {
        animator.Play("finich");
        btn.SetActive(false);
        off();
    }
}
