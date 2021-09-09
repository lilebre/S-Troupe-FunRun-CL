using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToRightPush : MonoBehaviour
{
    public float pushSpeed;
    float pushPositive;
    float pushNegative;

    void Start()
    {
        pushPositive = pushSpeed;
        pushNegative = -pushSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * pushSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x > 8f)
        {
            pushSpeed = pushNegative;
        }
        else if (transform.position.x < -4f)
        {

            pushSpeed = pushPositive;
        }
    }

}
