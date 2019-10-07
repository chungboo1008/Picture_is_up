using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using TMPro;

public class Thing : MonoBehaviour {

    public GameObject image_thing;

    public GameObject[] things;
    public Material[] material;
    public Renderer[] renderer; 
    public AudioClip[] clip;
    public AudioSource myAudioSource;
    public TextMeshProUGUI textmeshpro_thing, textmeshpro_color;

    static int thing_kind = 0;

    //一開始=0
    float count = 0f;

    public void changed(float a)
    {
        count = count + a;
        if (count % 2.0f == 0f)
            image_thing.SetActive(true);
        else
            image_thing.SetActive(false);
    }

    public int thing_return()
    {
        return thing_kind;
    }

    public void thing_select(int number)
    {
        thing_kind = number;
        Debug.Log("number:" + thing_kind);
        for (int index = 0; index < 11; index++)
            things[index].SetActive(false);

        textmeshpro_color.text = "";

        Thing_Color_Change thing_color_change;
        GameObject gameObject = new GameObject("Thing_Color_Change");
        thing_color_change = gameObject.AddComponent<Thing_Color_Change>();
        thing_color_change.setting(renderer[thing_kind], material[thing_kind], material[thing_kind], thing_kind);

        switch (number)
        {
            case 0:
                things[0].SetActive(true);
                textmeshpro_thing.text = "chameleon";
                break;
            case 1:
                things[1].SetActive(true);
                textmeshpro_thing.text = "parrot";
                break;
            case 2:
                things[2].SetActive(true);
                textmeshpro_thing.text = "fish";
                break;
            case 3:
                things[3].SetActive(true);
                textmeshpro_thing.text = "pig";
                break;
            case 4:
                things[4].SetActive(true);
                textmeshpro_thing.text = "elephant";
                break;
            case 5:
                things[5].SetActive(true);
                textmeshpro_thing.text = "tiger";
                break;
            case 6:
                things[6].SetActive(true);
                textmeshpro_thing.text = "lemon";
                break;
            case 7:
                things[7].SetActive(true);
                textmeshpro_thing.text = "leaf";
                break;
            case 8:
                things[8].SetActive(true);
                textmeshpro_thing.text = "heather";
                break;
            case 9:
                things[9].SetActive(true);
                textmeshpro_thing.text = "grass";
                break;
            case 10:
                things[10].SetActive(true);
                textmeshpro_thing.text = "mushroom";
                break;
            default:
                things[0].SetActive(true);
                textmeshpro_thing.text = "";
                break;
        }
        myAudioSource.Stop();
        myAudioSource.clip = clip[number];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
    }

	// Use this for initialization
	void Start () {
        /*for (int index = 0; index < 7; index++)
            renderer[index].GetComponent<Renderer>();*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
