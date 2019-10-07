using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Thing_Color_Change : MonoBehaviour {

    public GameObject animal;

    public Renderer renderer;
    public Material material1, material2;
    int kind;

    public void setting(Renderer r, Material m1, Material m2, int k)
    {
        renderer = r;
        material1 = m1;
        material2 = m2;
        kind = k;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        switch (kind)
        {
            case 0:
                for(int index = 0;index <17; index ++){
                    if (index != 2)
                        renderer.materials[index].Lerp(material1,material2,1);
                }
                break;
            case 1:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 2:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 3:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 4:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 5:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 6:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 7:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 8:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            case 9:
                for (int index = 0; index < 4; index++)
                    renderer.materials[index].Lerp(material1, material2, 1);
                break;
            case 10:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;
            /*default:
                renderer.materials[0].Lerp(material1, material2, 1);
                break;*/
        }
	}
}
