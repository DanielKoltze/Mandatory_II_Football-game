using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeElapsed = 0.0f; 
    public TextMeshProUGUI timerText;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        timerText.text = "Time: " + Mathf.RoundToInt(timeElapsed);
    }
}
