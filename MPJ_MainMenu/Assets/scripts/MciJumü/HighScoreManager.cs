using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    public GameObject player; // Reference to the Player GameObject
    public GameObject highScoreCanvas; // Reference to the High Score Canvas GameObject

    private bool isPlayerDestroyed = false;

    void Update()
    {
        if (!isPlayerDestroyed && player == null)
        {
            isPlayerDestroyed = true;
            highScoreCanvas.SetActive(true);
        }

    }
}