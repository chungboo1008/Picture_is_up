using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Elephant : MonoBehaviour
{

    public GameObject elephant;
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
        elephant.SetActive(true);
        animator.Play("idle");
        Debug.Log("elephant display");
    }

    public void notActive()
    {
        elephant.SetActive(false);
        Debug.Log("felephant not display");
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
