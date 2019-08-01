using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject playerCar;
    public float x;
    public float y;
    public float z;

	// Update is called once per frame
	void Update () {
        x = playerCar.transform.eulerAngles.x;
        y = playerCar.transform.eulerAngles.y;
        z = playerCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(x - x, y, z - z);
    }
}
