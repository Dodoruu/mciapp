using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove2 : MonoBehaviour
{
    private Vector3 touchPosition;
    private Rigidbody2D rb;
    private Vector3 direction;
    private float movespeed = 10f;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToViewportPoint(touch.position);
            touchPosition.z = 0;
            direction = (touchPosition - transform.position);
            rb.velocity = new Vector2(direction.x, direction.y) * movespeed;

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = Vector2.zero;

        }
    }
}
