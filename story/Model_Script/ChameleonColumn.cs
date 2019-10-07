using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChameleonColumn : MonoBehaviour
{

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    public Renderer renderer;
    public Material[] material;

    int page = 0;

    // Use this for initialization
    void Start()
    {
        renderer.GetComponent<Renderer>();
        for (int index = 0; index < 9; index++)
        {
                renderer.materials[index].Lerp(material[0], material[0], 1);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void select(int p)
    {
        page = p;
    }

    public void Active()
    {
        if (page == 22)
        {
            myAudioSource.Stop();
            myAudioSource.clip = clip[0];
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }
        }
        else if (page == 23)
        {
            chameleon.SetActive(true);
            animator.Play("idle");;
        }
    }

    public void notActive()
    {
        chameleon.SetActive(false);
    }

    private void OnMouseDown()
    {
        Debug.Log("EventTrigger:" + gameObject.name);
        animator.Play("happy");
        /*myAudioSource.Stop();
        myAudioSource.clip = clip[1];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }*/
    }
}
