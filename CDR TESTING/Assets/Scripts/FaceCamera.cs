using UnityEngine;

[ExecuteInEditMode]
public class FaceCamera : MonoBehaviour {
    
    Transform cam;
    Vector3 targetAngle = Vector3.zero;

    void Start() {
        cam = Camera.main.transform;
    }

    void Update() { // makes element face the camera
        
        transform.LookAt(cam);
        targetAngle = transform.localEulerAngles;
        targetAngle.y = 0; // will not rotate about the x axis
        targetAngle.x = 0; // will not rotate about the z axis
        transform.localEulerAngles = targetAngle;
    }
}
