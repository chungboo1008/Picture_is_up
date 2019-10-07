using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChameleonFallDownWithLeaf : MonoBehaviour {

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    public Renderer renderer;
    public Material[] material;

	// Use this for initialization
	void Start () {
		
	}

    public void animation_initial()
    {
        animator = chameleon.GetComponent<Animator>();
        renderer.GetComponent<Renderer>();
        for (int index = 0; index < 9; index++)
            renderer.materials[index].Lerp(material[0], material[0], 1);
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
        animator.Play("fall");
        Debug.Log("fish display");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
        Debug.Log("fish not display");
    }

    /*private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        animator.Play("swim");
        myAudioSource.Stop();
        myAudioSource.clip = clip[1];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
    }*/
}
