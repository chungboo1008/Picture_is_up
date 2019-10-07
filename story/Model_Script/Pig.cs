using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Pig : MonoBehaviour
{

    public GameObject pig;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Active()
    {
        myAudioSource.Stop();
        myAudioSource.clip = clip[0];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
        pig.SetActive(true);
        animator.Play("idle");
        Debug.Log("pig display");
    }

    public void notActive()
    {
        pig.SetActive(false);
        Debug.Log("pig not display");
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        animator.Play("walk");
        myAudioSource.Stop();
        myAudioSource.clip = clip[1];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
    }
}
