using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Tiger_With_Chameleon : MonoBehaviour {

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    public Renderer renderer;
    public Material[] material;

    int page = 0;
    bool check = true;

	// Use this for initialization
	void Start () {
		
	}

    public void animation_initial(int p)
    {
        animator = chameleon.GetComponent<Animator>();
        
        renderer.GetComponent<Renderer>();
        if (p == 14)
        {
            page = 14;
            for (int index = 0; index < 17; index++)
                    {
                        if (index != 9)
                            renderer.materials[index].Lerp(material[0], material[0], 1);
                    }
            animator.Play("stripe");
        }
        else if (p == 15)
        {
            page = 15;
            animator.Play("crawl");
        }
        else if (p == 16)
        {
            page = 16;
            animator.Play("idle");
        }

        //animator.Play("crawl");
        //check = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (page == 14 && check)
        {
            check = false;
            Color_Change_Row color_change_row;
            GameObject gameObject = new GameObject("Color_Change_Row");
            color_change_row = gameObject.AddComponent<Color_Change_Row>();
            color_change_row.color_select(renderer, material[0], material[1], material[2], 1);
            color_change_row.Update();
            /*myAudioSource.Stop();
            myAudioSource.clip = clip[3];
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }*/
        }
	}

    public void Active()
    {
        myAudioSource.Stop();
        myAudioSource.clip = clip[page - 14];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
        chameleon.SetActive(true);
        //animator.Play("crawl");
        //Debug.Log("crawling");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
        Debug.Log("not display");
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        if(page == 14)
            check = true;
        else if (page == 15)
        {
            myAudioSource.Stop();
            myAudioSource.clip = clip[page - 14];
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }
        }
        //animation_initial();
    }
}
