using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAndCircMovement : MonoBehaviour
{
    public float movSpeed = 1f;
    float movPositive;
    float movNegative;

    private void Start()
    {
        movPositive = movSpeed;
        movNegative = -movSpeed;
    }


    void Update()
    {
        transform.Translate(1 * -movSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -5)
        {
            movSpeed = movNegative;
        } else if (transform.position.x >= 5)
        {
            movSpeed = movPositive;
        }
        
    }


}
