using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float countdownTime = 15f; // Total time for the countdown
    public Text timerText; // Reference to the UI text displaying the timer
    private bool isCounting = false; // Flag to control the countdown

    private void Update()
    {
        if (isCounting)
        {
            countdownTime -= Time.deltaTime; // Reduce countdown time based on the frame rate
            UpdateTimerText();

            if (countdownTime <= 0f)
            {
                countdownTime = 0f;
                UpdateTimerText();
                isCounting = false;
            }
        }
    }

    public void reset()
    {
        countdownTime = 15f;
        UpdateTimerText();

    }


    public void StartCountdown()
    {
        if (!isCounting)
        {
            isCounting = true;
        }
    }

    private void UpdateTimerText()
    {
        int seconds = Mathf.FloorToInt(countdownTime % 60);
        timerText.text = seconds.ToString();
    }
}
