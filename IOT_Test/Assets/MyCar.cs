using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyCar : MonoBehaviour {

    public float[] speed = new float[5] { 10f, 20f, 30f, 40f, 50f };
   // public Text textOutput;
   // public Text gearText;

    private int gear;
	// Use this for initialization
	void Start () {
        gear = 1;
	}
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
            gear++;
        if (Input.GetKeyDown(KeyCode.X))
            gear--;
    }

    void LateUpdate()
    {
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime * speed[gear-1]);
        transform.Rotate(0f, Input.GetAxis("Horizontal") * Time.deltaTime * 100, 0f);
       // textOutput.text = (Input.GetAxis("Vertical") * Time.deltaTime * speed[gear-1]).ToString();
      //  gearText.text = gear.ToString();
    }
}
