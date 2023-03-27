using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PauseButton : MonoBehaviour
{
    public Sprite pausepanel;
    public Button pauseButton;
    public GameObject pausePlane;

    private bool isPaused = false; 
    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0; 
            isPaused = true;
            pausePlane.SetActive(true);

        }
        else
        {
            Time.timeScale = 1; 
            isPaused = false;
            pausePlane.SetActive(false);    
        }
    }

    
    private void Start()
    {
        pauseButton.onClick.AddListener(PauseGame); 
    }
}
