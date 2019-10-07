using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ChameleonInTheGrass : MonoBehaviour {

    public GameObject chameleon;
    public Animator animator;
    public AudioClip[] clip;
    public AudioSource myAudioSource;

    public Renderer rendererA, rendererB;
    public Material[] material;

    int page = 0;
    bool check_1 = true, check_2 = true, check_3 = true;

	// Use this for initialization
	void Start () {
		
	}

    public void color_initial(int p)
    {
        /*rendererA.GetComponent<Renderer>();
        rendererB.GetComponent<Renderer>();
        if (p == 24)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[0], 1);
                    rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
        }
        else if (p == 25 || p == 26)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
        }
        else if (p == 27 || p == 28)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    if (index == 8 || index == 7 || index == 6 || index == 4 || index == 5)
                        rendererB.materials[index].Lerp(material[0], material[1], 1);
                    else
                        rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
        }
        else if (p == 29)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    rendererB.materials[index].Lerp(material[0], material[1], 1);
                }
            }
        }*/
    }

    public void animation_initial(int p)
    {
        page = p;
        animator = chameleon.GetComponent<Animator>();
        rendererA.GetComponent<Renderer>();
        rendererB.GetComponent<Renderer>();

        if (p == 24)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[0], 1);
                    rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
            animator.Play("animation_1");
            Debug.Log("IN:1");
        }
        else if (p == 25)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
            animator.Play("animation_2");
            Debug.Log("IN:2");
        }
        else if (p == 26)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
            animator.Play("animation_3");
            Debug.Log("IN:3");
        }
        else if (p == 27)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    if(index == 8 || index == 7 || index == 6 || index == 4 || index == 5)
                        rendererB.materials[index].Lerp(material[0], material[1], 1);
                    else
                        rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
            animator.Play("animation_4");
            Debug.Log("IN:4");
        }
        else if (p == 28)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    if (index == 8 || index == 7 || index == 6 || index == 4 || index == 5)
                        rendererB.materials[index].Lerp(material[0], material[1], 1);
                    else
                        rendererB.materials[index].Lerp(material[0], material[0], 1);
                }
            }
            animator.Play("animation_5");
            Debug.Log("IN:5");
        }
        else if (p == 29)
        {
            for (int index = 0; index < 17; index++)
            {
                if (index != 9)
                {
                    rendererA.materials[index].Lerp(material[0], material[1], 1);
                    rendererB.materials[index].Lerp(material[0], material[1], 1);
                }
            }
            animator.Play("animation_6");
            Debug.Log("IN:6");
        }

        //animator.Play("crawl");
        //check = true;
    }

	// Update is called once per frame
	void Update () {
        if (page == 24 && check_1)
        {
            check_1 = false;
            Color_Change_Row color_change_row;
            GameObject gameObject = new GameObject("Color_Change_Row");
            color_change_row = gameObject.AddComponent<Color_Change_Row>();
            color_change_row.color_select(rendererA, material[0], material[1], material[2], 1);
            color_change_row.Update();
        }
        else if (page == 26 && check_2)
        {
            check_2 = false;
            Color_Change_Row color_change_row;
            GameObject gameObject = new GameObject("Color_Change_Row");
            color_change_row = gameObject.AddComponent<Color_Change_Row>();
            color_change_row.color_select(rendererB, material[0], material[1], material[2], 2);
            color_change_row.Update();
        }
        else if (page == 28 && check_3)
        {
            check_3 = false;
            Color_Change_Row color_change_row;
            GameObject gameObject = new GameObject("Color_Change_Row");
            color_change_row = gameObject.AddComponent<Color_Change_Row>();
            color_change_row.color_select(rendererB, material[0], material[1], material[2], 3);
            color_change_row.Update();
        }
	}

    public void Active()
    {
        myAudioSource.Stop();
        myAudioSource.clip = clip[page - 24];
        if (!myAudioSource.isPlaying)
        {
            myAudioSource.Play();
        }
        chameleon.SetActive(true);
        //animator.Play("crawl");
        //Debug.Log("crawling");
    }

    public void notActive()
    {
        chameleon.SetActive(false);
        Debug.Log("not display");
    }
}
