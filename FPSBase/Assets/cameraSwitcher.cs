using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class cameraSwitcher : MonoBehaviour {

    public Camera fpCamera;
    public Camera thisCam;
    public GameObject followObject;
    public FirstPersonController fpsController;
    private Transform thisTransform;

    // Use this for initialization
    void Start () {
        fpCamera.enabled = true;
        thisCam.enabled = false;
        thisTransform = gameObject.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
		
        //to switch perspectives
        if(Input.GetKeyDown(KeyCode.C))
        {
            fpCamera.enabled = !fpCamera.enabled;
            thisCam.enabled = !thisCam.enabled;
            fpsController.isSideView = !fpsController.isSideView;
        }

        //to keep 2d camera in the right place
        if((thisTransform.position.z != followObject.transform.position.z) || (thisTransform.position.y != followObject.transform.position.y))
        {
            Vector3 tempTransform = followObject.transform.position;
            tempTransform.x += 4.0f;
            thisTransform.position = tempTransform;
        }
	}
}
