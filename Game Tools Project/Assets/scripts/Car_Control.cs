using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car_Control : MonoBehaviour
{
    public float MotorForce, SteerForce, Brakeforce;
    public WheelCollider FR_L_Wheel, FR_R_Wheel, RE_L_Wheel, RE_R_Wheel;
    public Text countText;
    public Text completeText;
   
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        completeText.text = "";
        
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();

        }
    }
    void SetCountText()
    {
        countText.text = "count: " + count.ToString();
        if (count >= 10)
        {
            completeText.text = "You Win";
            
        }
       
    }
}
