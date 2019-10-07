using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class YellowChameleon : MonoBehaviour {

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    public Renderer rendererA, rendererB;
    public Material[] material;

	// Use this for initialization
	void Start () {
        //animator = chameleon.GetComponent<Animator>();
        rendererA.GetComponent<Renderer>();
        rendererB.GetComponent<Renderer>();

        for (int index = 0; index < 2; index++)
        {
            rendererA.materials[index].Lerp(material[0], material[0], 1);
            rendererB.materials[index].Lerp(material[0], material[0], 1);
        }
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
