using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 45f;

    [SerializeField] Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        countdownText.color = Color.clear; // Timer will remain invisible until the last 10 seconds where it will change colours
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime; // decrease 1 per second
        countdownText.text = currentTime.ToString("0");

        if ((currentTime <= 10) && (currentTime > 5))
        {
            countdownText.color = Color.white;
        }
        if (currentTime <= 5)
        {
            countdownText.color = Color.blue;
        }

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
