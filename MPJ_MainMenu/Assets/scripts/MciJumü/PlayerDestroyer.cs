using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyer : MonoBehaviour
{
    private bool isFalling = false;
    private float fallTimer = 0f;
    private float fallThreshold = 0.5f; // 1.5 seconds

    void Update()
    {
        if (transform.position.y < 0f) // Check if object is falling (below y=0)
        {
            if (!isFalling)
            {
                isFalling = true;
                fallTimer = 0f;
            }
            else
            {
                fallTimer += Time.deltaTime;
                if (fallTimer >= fallThreshold)
                {
                    Destroy(gameObject);
                }
            }
        }
        else
        {
            isFalling = false;
        }
    }
}




