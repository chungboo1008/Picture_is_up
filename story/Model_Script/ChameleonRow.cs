using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChameleonRow : MonoBehaviour{

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    int page = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void select(int p)
    {
        page = p;
    }

    public void Active()
    {
        myAudioSource.Stop();
        if(page == 1)
            myAudioSource.clip = clip[0];
        else
            myAudioSource.clip = clip[page - 9];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
        chameleon.SetActive(true);
        animator.Play("idle");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
        Debug.Log("chameleon not display");
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        //animator.Play("happy");
        /*myAudioSource.Stop();
        myAudioSource.clip = clip[1];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }*/
    }
}
