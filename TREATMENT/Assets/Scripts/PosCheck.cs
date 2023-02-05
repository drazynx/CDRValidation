using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PosCheck : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 4f;

    [SerializeField] Text CDToSceneSwitch;

    public Transform user;
    Renderer ren;

    void Start()
    {
        currentTime = startingTime;
        CDToSceneSwitch.color = Color.clear; // Timer will remain invisible until the last 10 seconds where it will change colours
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(user.localEulerAngles);

        if (user.eulerAngles.z <= 50f && user.eulerAngles.z >= 40f)
        {
            //Debug.Log(user.eulerAngles.z);
            ren = GetComponent<Renderer>();
            ren.material.color = Color.green; //color change to confirm
            //start 3 second countdown to move to next scene

            currentTime -= 1 * Time.deltaTime; // to decrease 1 per second b/c 60fps. Might need to be changed
            CDToSceneSwitch.text = currentTime.ToString("0");
            CDToSceneSwitch.color = Color.white;

            if (currentTime <= 0) 
            {
                //invoke("NextScene");
                SceneManager.LoadScene("TreatmentTwoR"); //advances to next scene
                //currentTime = 0; //stops from going negative
            }
        }
        else
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.blue; // object becomes blue when angle does not match

            currentTime = 4f; //reset timer when angle is wrong
            CDToSceneSwitch.color = Color.clear; // timer becomes clear when angle does not match
        }
    }
}
