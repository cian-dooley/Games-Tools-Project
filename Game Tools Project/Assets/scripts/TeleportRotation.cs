using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRotation : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(60, 50, 20) * Time.deltaTime);
    }
}
