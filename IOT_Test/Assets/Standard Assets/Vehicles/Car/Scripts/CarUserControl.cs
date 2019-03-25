using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.IO.Ports; //Library to read our ardunio data
using System.Collections;//to use Ienumarator in our code
using UnityEngine.UI;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private bool isFinished;
        private CarController m_Car; // the car controller we want to use
        private CameraMode cameraControl;
        private FinishRace endTimeCalc;
        SerialPort seri = new SerialPort("COM4", 9600);//define our port
        float h;//horizontal (car direction)
        float v;//vertical (car speed)
        int mode;//camera mode value
 //       public Text score;

        private void Awake()
        {
            // get the car controller
            seri.Open();//open our port
            StartCoroutine(ReadDataFromSerialPort());//start loop
            m_Car = GetComponent<CarController>();
            cameraControl = GetComponent<CameraMode>();
            endTimeCalc = FindObjectOfType<FinishRace>();
        }

        private void Start()
        {
            isFinished = false;
        }

        public void setFinished(bool value)
        {
            isFinished = value;
        }

        IEnumerator ReadDataFromSerialPort()
        {
   //         score.text = isFinished.ToString();
            if (isFinished)
            {
                float endTime = endTimeCalc.GetEndTime();
                Debug.Log(endTime.ToString());
                //score.text = endTime.ToString();
                /*if (seri.IsOpen == false)
                {
                    seri.Open();
                    seri.Write(endTime.ToString());
                }
                seri.Write(endTime.ToString());*/
            }
            else if(!isFinished) {
                while (true)
                {//loop
                    string[] values = seri.ReadLine().Split(',');//we split our string value by , because we write string as carspeed,cartotation in our ardunio codes
                    v = (float.Parse(values[0])) / 100;
                    h = (float.Parse(values[1])) / 100;
                    mode = int.Parse(values[2]);
                    yield return new WaitForSeconds(.01f);//waiting seconds to read data. It should be same as ardunio code loop delay
                }
            }

        }

        private void FixedUpdate()
        {
            // pass the input to the car!
            //Close old codes which created by unity team
            //float h = CrossPlatformInputManager.GetAxis("Horizontal");
            //float v = CrossPlatformInputManager.GetAxis("Vertical");
            if (mode == 1 || mode == 2 || mode == 3)
            { cameraControl.ChangeMode(mode); }

#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(-h,v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
