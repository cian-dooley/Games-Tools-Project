using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    public Transform target = null;
    public Transform target2 = null;
    bool bJump = false;
    bool bJump2 = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Teleport3" && bJump == false && bJump2 == false)
        {
            this.transform.position = target.position;
            bJump = true;
        }

        if (other.gameObject.tag == "Teleport4" && bJump == false && bJump2 == false) 
        {
            this.transform.position = target2.position;
            bJump2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Teleport3")
        {
            bJump2 = false;
        }
        if (other.gameObject.tag == "Teleport4")
        {
            bJump = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
