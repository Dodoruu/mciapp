using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMoveTut : MonoBehaviour
{
    public float moveSpeed;

  
    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(mousePos.y > 1)
            {
                transform.Translate(0, moveSpeed, 0);
            }

            if(mousePos.y < -1)
            {
                transform.Translate(0, -moveSpeed, 0);
            }

        }
    }
}
