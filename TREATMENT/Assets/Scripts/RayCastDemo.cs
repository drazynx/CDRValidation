using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastDemo : MonoBehaviour
{
    public float range = 5;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));
    }
}
