using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChameleonCrawlInHeather : MonoBehaviour {

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    public Renderer renderer;
    public Material[] material;

    AnimatorStateInfo stateinfo;
    bool check = false;

	// Use this for initialization
	void Start () {
		
	}

    public void animation_initial()
    {
        animator = chameleon.GetComponent<Animator>();
        renderer.GetComponent<Renderer>();
        for (int index = 0; index < 17; index++)
        {
            if(index != 9)
                renderer.materials[index].Lerp(material[0], material[0], 1); 
        }

        animator.Play("crawl");
        check = true;
    }
	
	// Update is called once per frame
	void Update () {
        animator = chameleon.GetComponent<Animator>();
        stateinfo = animator.GetCurrentAnimatorStateInfo(0);
        //stateinfo.IsName("Base Layer.crawl") == false
        //stateinfo.length < 3
        //stateinfo.normalizedTime <= 0.2 && 
        if (check == true)
        {
            Debug.Log("time*" + stateinfo.length);
            check = false;
            Color_Change_Row color_change_row;
            GameObject gameObject = new GameObject("Color_Change_Row");
            color_change_row = gameObject.AddComponent<Color_Change_Row>();
            color_change_row.color_select(renderer, material[0], material[1], material[1], 1);
            color_change_row.Update();
            /*myAudioSource.Stop();
            myAudioSource.clip = clip[1];
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }*/
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
        animator.Play("crawl");
        Debug.Log("crawling");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
        Debug.Log("not display");
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        animation_initial();
    }
}
