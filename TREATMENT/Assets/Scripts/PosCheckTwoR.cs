using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PosCheckTwoR : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 4f;
    float helpTime = 25f; // will change to higher value like 45 on final build

    [SerializeField] Text CDToSceneSwitch;
    
    public AudioSource myAudio;
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
        helpTime -= 1 * Time.deltaTime; // to decrease 1 per second b/c 60fps. Might need to be changed
        CDToSceneSwitch.text = helpTime.ToString("0");

        if (helpTime < 0)
        {
            SceneManager.LoadScene("Treatment0"); //cancels treatment process and puts up help screen
        }

        if (user.eulerAngles.x <= 110f && user.eulerAngles.x >= 80f)
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.green; //color change to confirm

            playConfirm(); // plays audio confirming patient are in the right location

            currentTime -= 1 * Time.deltaTime; // to decrease 1 per second b/c 60fps. Might need to be changed
            CDToSceneSwitch.text = currentTime.ToString("0"); //timer in whole numbers
            CDToSceneSwitch.color = Color.white; //timer becomes visible

            if (currentTime <= 0) //stops from going negative, advances to next scene
            {
                SceneManager.LoadScene("Treatment3R");
            }
        }
        else
        {
            ren = GetComponent<Renderer>();
            ren.material.color = Color.blue; // object becomes blue when angle does not match

            currentTime = 4f; //reset timer when angle is wrong
            CDToSceneSwitch.color = Color.clear; // timer becomes clear when angle does not match
        }

        void playConfirm()
        {
            //myAudio.Pause();
            myAudio = GetComponent<AudioSource>();
            myAudio.clip = Resources.Load<AudioClip>("Scene1LRPerfect"); //loads audio clip
            myAudio.Play(); // plays audio confirming patient are in the right location
        }
    }
}
