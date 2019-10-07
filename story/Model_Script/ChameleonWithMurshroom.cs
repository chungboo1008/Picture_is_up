using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChameleonWithMurshroom : MonoBehaviour {

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
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
        animator.Play("idle");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
    }
}
