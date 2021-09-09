using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Touch touch;

    public float movSpeed;
    public float forwardForce = 5f;

    float xTestMovement;
    public float movementTestSpeed = 1;


    void Update()
    {
        transform.Translate(0, 0, 1 * forwardForce * Time.deltaTime);
        MovementMobile();
        //PcTestMovement();
    }

    void MovementMobile()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * movSpeed * Time.deltaTime, transform.position.y, transform.position.z);
            }
        }
    }

    void PcTestMovement()
    {
        xTestMovement = Input.GetAxis("Horizontal");
        transform.Translate(xTestMovement * movementTestSpeed * Time.deltaTime, 0, 0);
        //Debug.Log(xTestMovement);
    }

    public void ChangeSpeedLow()
    {
        forwardForce = 4f;
    }

    public void ChangeSpeedMid()
    {
        forwardForce = 8f;
    }

    public void ChangeSpeedHigh()
    {
        forwardForce = 12f;
    }

    public void ChangeInputSensLow()
    {
        movSpeed = 0.8f;
    }

    public void ChangeInputSensMid()
    {
        movSpeed = 1.1f;
    }

    public void ChangeInputSensHigh()
    {
        movSpeed = 1.5f;
    }
}
