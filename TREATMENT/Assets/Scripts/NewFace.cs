using UnityEngine;

[ExecuteInEditMode]
public class NewFace : MonoBehaviour {
    Transform cam;
    Vector3 targetAngle = Vector3.zero;

    void Start() {
        cam = Camera.main.transform;
    }

    void Update() {

        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        //targetAngle.x = 0; // will not rotate about the x axis
        targetAngle.y = 0; // will not rotate about the y axis
        transform.localEulerAngles = targetAngle;
    }
}
