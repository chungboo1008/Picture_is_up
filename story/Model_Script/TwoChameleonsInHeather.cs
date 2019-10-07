using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TwoChameleonsInHeather : MonoBehaviour {

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    public Renderer rendererA, rendererB;
    public Material[] material;

    bool check = true;

	// Use this for initialization
	void Start () {
		
	}

    public void animation_initial()
    {
        animator = chameleon.GetComponent<Animator>();
        rendererA.GetComponent<Renderer>();
        rendererB.GetComponent<Renderer>();
        for (int index = 0; index < 17; index++)
        {
            if (index != 9)
            {
                rendererA.materials[index].Lerp(material[0], material[0], 1);
                rendererB.materials[index].Lerp(material[0], material[0], 1);
            }   
        }
        animator.Play("walk");
        check = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (check)
        {
            check = false;
            Color_Change_Row color_change_row_1, color_change_row_2;
            GameObject gameObject_1 = new GameObject("Color_Change_Row");
            GameObject gameObject_2 = new GameObject("Color_Change_Row");
            color_change_row_1 = gameObject_1.AddComponent<Color_Change_Row>();
            color_change_row_2 = gameObject_2.AddComponent<Color_Change_Row>();
            color_change_row_1.color_select(rendererA, material[0], material[1], material[1], 1);
            color_change_row_2.color_select(rendererB, material[0], material[1], material[1], 1);
            color_change_row_1.Update();
            color_change_row_2.Update();
        }
        
	}

    public void Active()
    {
        myAudioSource.Stop();
        myAudioSource.clip = clip[0];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
        chameleon.SetActive(true);
        animator.Play("walk");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
    }
}
