using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Parrot : MonoBehaviour {

    public GameObject parrot;
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
        parrot.SetActive(true);
        animator.Play("idle");    
        Debug.Log("parrot display");
    }

    public void notActive()
    {
        parrot.SetActive(false);
        Debug.Log("parrot not display");
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        animator.Play("fly");   
        myAudioSource.Stop();
        myAudioSource.clip = clip[1];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
    }
}
