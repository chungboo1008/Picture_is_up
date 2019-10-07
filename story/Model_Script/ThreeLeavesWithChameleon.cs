using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ThreeLeavesWithChameleon : MonoBehaviour {

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
        Debug.Log("display");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
        Debug.Log("fish not display");
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        /*animator.Play("wind");
        myAudioSource.Stop();
        myAudioSource.clip = clip[1];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }*/
    }
}
