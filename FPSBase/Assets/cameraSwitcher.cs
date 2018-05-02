using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class cameraSwitcher : MonoBehaviour {

    public Camera fpCamera;
    public Camera thisCam;

	// Use this for initialization
	void Start () {
        fpCamera.enabled = true;
        thisCam.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.C))
        {
            fpCamera.enabled = !fpCamera.enabled;
            thisCam.enabled = !thisCam.enabled;
            gameObject.GetComponentInParent<FirstPersonController>().isSideView = !gameObject.GetComponentInParent<FirstPersonController>().isSideView;
        }
	}
}
