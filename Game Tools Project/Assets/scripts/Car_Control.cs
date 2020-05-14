using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Control : MonoBehaviour
{
    public float MotorForce, SteerForce, Brakeforce;
    public WheelCollider FR_L_Wheel, FR_R_Wheel, RE_L_Wheel, RE_R_Wheel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * MotorForce;
        float h = Input.GetAxis("Horizontal") * SteerForce;

        RE_R_Wheel.motorTorque = v;
        RE_L_Wheel.motorTorque = v;

        FR_L_Wheel.steerAngle = h;
        FR_R_Wheel.steerAngle = h;

        if (Input.GetKey(KeyCode.Space))
        {
            RE_L_Wheel.brakeTorque = Brakeforce;
            RE_R_Wheel.brakeTorque = Brakeforce;
        }
        if(Input.GetKey(KeyCode.Space))
        {
            RE_L_Wheel.brakeTorque = 0;
            RE_R_Wheel.brakeTorque = 0;
        }
        if(Input.GetAxis("Vertical") == 0)
        {
            RE_L_Wheel.brakeTorque = Brakeforce;
            RE_R_Wheel.brakeTorque = Brakeforce;
        }
        else
        {
            RE_L_Wheel.brakeTorque = 0;
            RE_R_Wheel.brakeTorque = 0;
        }

    }
}
