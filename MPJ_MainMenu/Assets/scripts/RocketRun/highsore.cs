using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highsore: MonoBehaviour
{
    public Text timeText;
    public Text highScoreText;

    public float currentTime;
    public float highScore;

   
    void Start()
    {
        
        highScore = PlayerPrefs.GetFloat("HighScore", 0);
        highScoreText.text = FormatTime(highScore);
    }

 
    void Update()
    {
        
        currentTime += Time.deltaTime;

        
        timeText.text =  FormatTime(currentTime);

      
        if (currentTime > highScore)
        {
           
            highScore = currentTime;
            PlayerPrefs.SetFloat("HighScore", highScore);
            highScoreText.text =  FormatTime(highScore);
        }
    }

    
    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        int milliseconds = Mathf.FloorToInt((time - Mathf.FloorToInt(time)) * 1000);
        return string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }
}

