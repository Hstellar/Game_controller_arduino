using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CameraMode))]
public class ChangeModeUserController : MonoBehaviour {
    
    private CameraMode cameraControl;

	// Use this for initialization
	void Awake () {
        cameraControl = GetComponent<CameraMode>();
    }

    // Update is called once per frame
    void Update () {
        /*
            Instead of this if condition, we need following conditions to be satiesfied
            1. value from keypad = 0, then do nothing
            2. value from keypad = 1, 2, 3 then store it int mode and pass it
            3. value from keypad other than 1, 2, 3 then do nothing
        */
        if (Input.GetKeyDown(KeyCode.C))
        {
            int mode = 2;
            cameraControl.ChangeMode(mode);
        }	
	}
}
