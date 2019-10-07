using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Dropdown : MonoBehaviour {

    public Dropdown myDropdown;
    public GameObject ButtonList;

	// Use this for initialization
	void Start () {
        /*ButtonList[0].SetActive(true);
        ButtonList[1].SetActive(false);*/
        ButtonList.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnValueChanged()
    {
        /*switch(myDropdown.value){
            case 0:
                ButtonList.SetActive(true);
                break;
            case 1:
                ButtonList.SetActive(false);
                break;
        }*/
    }
}
