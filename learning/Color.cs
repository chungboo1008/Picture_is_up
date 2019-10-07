using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class Color : MonoBehaviour {

    public GameObject image_color;

    public TextMeshProUGUI textmeshpro;
    public AudioClip[] clip;
    public AudioSource myAudioSource;
    public Material[] material;
    public Renderer[] r;

    Material material1, material2;
    Renderer renderer;

    int thing_kind = 0;
    static int color_kind = 0;
    //一開始=1
    float count = 1f;

    public void changed(float a)
    {
        count = count + a;
        if (count % 2.0f == 0f)
            image_color.SetActive(true);
        else
            image_color.SetActive(false);
    }

    public int color_return()
    {
        return color_kind;
    }

    public void color_select(int number)
    {
        Thing thing;
        GameObject gameobject = new GameObject("Thing");
        thing = gameobject.AddComponent<Thing>();
        thing_kind = thing.thing_return();
        renderer = r[thing_kind];

        switch (number)
        {
            case 0:
                textmeshpro.text = "red";
                material1 = material[0];
                material2 = material[0];
                break;
            case 1:
                textmeshpro.text = "orange";
                material1 = material[1];
                material2 = material[1];
                break;
            case 2:
                textmeshpro.text = "yellow";
                material1 = material[2];
                material2 = material[2];
                break;
            case 3:
                textmeshpro.text = "green";
                material1 = material[3];
                material2 = material[3];
                break;
            case 4:
                textmeshpro.text = "blue";
                material1 = material[4];
                material2 = material[4];
                break;
            case 5:
                textmeshpro.text = "purple";
                material1 = material[5];
                material2 = material[5];
                break;
            case 6:
                textmeshpro.text = "black";
                material1 = material[6];
                material2 = material[6];
                break;
            case 7:
                textmeshpro.text = "white";
                material1 = material[7];
                material2 = material[7];
                break;
            default:
                textmeshpro.text = "";
                break;
        }
        myAudioSource.Stop();
        myAudioSource.clip = clip[number];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }

        color_kind = number;
        Thing_Color_Change thing_color_change;
        GameObject gameObject = new GameObject("Thing_Color_Change");
        thing_color_change = gameObject.AddComponent<Thing_Color_Change>();
        thing_color_change.setting(renderer, material1, material2, thing_kind);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
