using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Color_Switch : MonoBehaviour{

    bool yellow_green = false, blue_purple = false;

    public Renderer renderer;
    public Material[] material;
    Material material1, material2, material3;

    float timer;
    int count = 0;
    int page = 0;

	// Use this for initialization
	void Start () {
        Debug.Log("hello");
        renderer.GetComponent<Renderer>();

        //color_select();
	}
	
	// Update is called once per frame
	public void Update () {
        timer += Time.deltaTime;
        for (int index = 0; index < 17; index++)
        {
            if (index != 9)
                renderer.materials[index].Lerp(material1, material2, timer * 1f);
        }

        InvokeRepeating("color_switch", 4, 5);
	}

    public void color_select(int p) 
    {
        page = p;
         if (page == 10)
        {
            material1 = material[0];
            material2 = material[1];
        }
        else if(page == 11)
        {
            material1 = material[2];
            material2 = material[4];
        }
         else if (page == 1)
         {
             material1 = material[5];
             material2 = material[6];
             count = 6;
         }
    }

    private void color_switch()
    {
        if (page == 1)
        {
            if (count == 6)
            {
                material1 = material[6];
                material2 = material[0];
                count = 0;
            }
            else
            {
                material1 = material[count];
                material2 = material[count + 1];
                count++;
            }
        }
        else
        {
            material3 = material1;
            material1 = material2;
            material2 = material3;
        }
        
        timer_reset();
        CancelInvoke("color_switch");
    }

    public void timer_reset()
    {
        timer = 0;
        Debug.Log("timer reset!!!");
    }

    public void color_reset()
    {
        Debug.Log("color reset!!!");
    }

    
}
