using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMode : MonoBehaviour {

    public GameObject normalCamera;
    public GameObject firstPersonCamera;
    public GameObject farCamera;
   
    void Start()
    {
        normalCamera.SetActive(true);
        firstPersonCamera.SetActive(false);
        farCamera.SetActive(false);
    }

    public void ChangeMode(int mode)
    {
        if (mode == 1)
        {
            normalCamera.SetActive(true);
            firstPersonCamera.SetActive(false);
            farCamera.SetActive(false);
        }
        if (mode == 2)
        {
            normalCamera.SetActive(false);
            firstPersonCamera.SetActive(false);
            farCamera.SetActive(true);
        }
        if (mode == 3)
        {
            normalCamera.SetActive(false);
            firstPersonCamera.SetActive(true);
            farCamera.SetActive(false);
        }
    }
}
