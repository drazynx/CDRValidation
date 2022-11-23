using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Gaze : MonoBehaviour {
    List<InfoBehavior> infos = new List<InfoBehavior>();

    void Start () {
        infos = FindObjectsOfType<InfoBehavior>().ToList();
    }

    void Update(){
        if (Physics.Raycast(transform.position,transform.forward, out RaycastHit hit)) {
            GameObject go = hit.collider.gameObject;
            if (go.CompareTag("hasInfo")) { // if colliding with object
                //print("PATIENT EYE FOUND");
                OpenInfo(go.GetComponent<InfoBehavior>()); // get info while looking
            }
        }
        else {//if not looking at game object, close info
            CloseAll();
        }
    }

    void OpenInfo(InfoBehavior desiredInfo) {
        foreach(InfoBehavior info in infos) {
            if (info == desiredInfo) {
                info.OpenInfo();
            } 
            else {
                info.CloseInfo();
            }
        }
    }

    void CloseAll() {
        foreach (InfoBehavior info in infos) {
            info.CloseInfo();
        }
    }
}
