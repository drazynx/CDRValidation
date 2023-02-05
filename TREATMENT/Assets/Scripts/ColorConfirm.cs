using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ColorConfirm : MonoBehaviour {
    // If head is rotated between 40 and 50 degrees, change color of object to green
    void Update() {
        if (Physics.Raycast(transform.position, transform.TransformDirection (Vector3.forward), out RaycastHit hitinfo, 20f))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.green);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20f, Color.white);
        }
        
    }
}
