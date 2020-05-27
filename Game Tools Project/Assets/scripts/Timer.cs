﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 240f;

    [SerializeField] Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");

       

        if (currentTime <= 0)
        {
            currentTime = 0;
            timerText.color = Color.red;
            timerText.text = "You Lose";
        }
    }
}
