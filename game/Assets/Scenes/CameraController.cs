using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform playerTransform;
    private Vector3 cameraOffSet;
   
    [Range(0.01f, 1f)]
    public float smoothFactor = 1f;

    public bool lookAtPlayer = false;

    void Start()
    {
        cameraOffSet = transform.position - playerTransform.position;

    }

    // Update is called once per frame
    void LateUpdate () {
        Vector3 cameraPosition = playerTransform.position + cameraOffSet;
      //  Quaternion cameraRotation = Quaternion.LookRotation(cameraNewOffSet);

      //  cameraRotation.x = transform.rotation.x;
      //  cameraRotation.z = transform.rotation.z;

      //  transform.rotation = Quaternion.Slerp(transform.rotation, cameraRotation, Time.deltaTime * 100);
        transform.position = Vector3.Slerp(transform.position, cameraPosition, smoothFactor);

        if (lookAtPlayer)
            transform.LookAt(playerTransform);
       
    }
}
