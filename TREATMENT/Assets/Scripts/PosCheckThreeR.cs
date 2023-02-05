using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PosCheckThreeR : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 45f;

    [SerializeField] Text CDToSceneSwitch;
    
    public AudioSource myAudio;
    public Transform user;

    void Start()
    {
        currentTime = startingTime;
        CDToSceneSwitch.color = Color.white; // Timer will remain invisible until the last 10 seconds where it will change colours
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; // to decrease 1 per second b/c 60fps. Might need to be changed
        CDToSceneSwitch.text = currentTime.ToString("0"); //timer in whole numbers

        if (currentTime <= 0) //stops from going negative, advances to next scene
        {
             SceneManager.LoadScene("Treatment4R");
        }
    }
}
