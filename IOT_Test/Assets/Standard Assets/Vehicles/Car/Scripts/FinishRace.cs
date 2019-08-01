using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car
{
    public class FinishRace : MonoBehaviour
    {

        private float startTime;
        private float endTime = 0f;
        public Text text;
        CarUserControl car;

        // Use this for initialization
        void Start()
        {
            startTime = Time.time;
            car = GetComponent<CarUserControl>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider collider)
        {
            endTime = Time.time - startTime;
            text.text = endTime.ToString();
            car.setFinished(true);
        }

        public float GetEndTime()
        {
            return endTime;
        }


    }
}