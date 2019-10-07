using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Color_Change_Row : MonoBehaviour{

    public Renderer renderer;
    public Material[] material;
    Material material1, material2, material3;

    float timer = 0;
    int condition = 0;

    // Use this for initialization
    void Start()
    {
        //renderer.GetComponent<Renderer>();
    }

    /*public void color_select(Renderer r, Material m1, Material m2)
    {
        renderer = r;
        material1 = m1;
        material2 = m2;
    }*/

    public void color_select(Renderer r, Material m1, Material m2, Material m3, int con)
    {
        renderer = r;
        material1 = m1;
        material2 = m2;
        material3 = m3;
        condition = con;
    }

    // Update is called once per frame
    public void Update(){
        float[] lerp = new float[16];
        float offset = 0.07f;

        timer += Time.deltaTime;
        for (int index = 0; index < 16; index++)
            lerp[index] = timer;

        lerp[0] = lerp[0] * 0.5f;
        for (int index = 1; index < 16; index++)
            lerp[index] = lerp[0] - offset * index;
        switch(condition){
            case 1:
                renderer.materials[8].Lerp(material1, material2, lerp[0]);
                renderer.materials[7].Lerp(material1, material3, lerp[1]);
                renderer.materials[6].Lerp(material1, material2, lerp[2]);
                renderer.materials[4].Lerp(material1, material3, lerp[3]);

                renderer.materials[5].Lerp(material1, material2, lerp[4]);
                renderer.materials[3].Lerp(material1, material3, lerp[5]);
                renderer.materials[0].Lerp(material1, material2, lerp[6]);
                renderer.materials[1].Lerp(material1, material3, lerp[7]);

                renderer.materials[16].Lerp(material1, material2, lerp[8]);
                renderer.materials[15].Lerp(material1, material3, lerp[9]);
                renderer.materials[14].Lerp(material1, material2, lerp[10]);
                renderer.materials[13].Lerp(material1, material3, lerp[11]);

                renderer.materials[12].Lerp(material1, material2, lerp[12]);
                renderer.materials[11].Lerp(material1, material3, lerp[13]);
                renderer.materials[10].Lerp(material1, material2, lerp[14]);
                renderer.materials[2].Lerp(material1, material3, lerp[15]);
                break;
            case 2:
                renderer.materials[8].Lerp(material1, material2, lerp[0]);
                renderer.materials[7].Lerp(material1, material3, lerp[1]);
                renderer.materials[6].Lerp(material1, material2, lerp[2]);
                renderer.materials[4].Lerp(material1, material3, lerp[3]);

                renderer.materials[5].Lerp(material1, material2, lerp[4]);
                break;
            case 3:
                renderer.materials[3].Lerp(material1, material3, lerp[0]);
                renderer.materials[0].Lerp(material1, material2, lerp[1]);
                renderer.materials[1].Lerp(material1, material3, lerp[2]);

                renderer.materials[16].Lerp(material1, material2, lerp[3]);
                renderer.materials[15].Lerp(material1, material3, lerp[4]);
                renderer.materials[14].Lerp(material1, material2, lerp[5]);
                renderer.materials[13].Lerp(material1, material3, lerp[6]);

                renderer.materials[12].Lerp(material1, material2, lerp[7]);
                renderer.materials[11].Lerp(material1, material3, lerp[8]);
                renderer.materials[10].Lerp(material1, material2, lerp[9]);
                renderer.materials[2].Lerp(material1, material3, lerp[10]);
                break;
        }
        
    }

    public void timer_reset()
    {
        timer = 0;
        Debug.Log("timer reset!!!");
    }
}
