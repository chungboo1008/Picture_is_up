using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Mushroom : MonoBehaviour
{

    public GameObject mushroom;
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
        mushroom.SetActive(true);
        animator.Play("idle");
        Debug.Log("mushroom display");
    }

    public void notActive()
    {
        mushroom.SetActive(false);
        Debug.Log("mushroom not display");
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        animator.Play("squeeze");
        myAudioSource.Stop();
        myAudioSource.clip = clip[1];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
    }
}
