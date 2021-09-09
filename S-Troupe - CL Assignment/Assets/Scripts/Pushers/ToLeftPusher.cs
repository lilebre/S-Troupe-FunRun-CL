using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToLeftPusher : MonoBehaviour
{

    public float pushSpeed = 10f;
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
        transform.Translate(-1 * pushSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -4)
        {
            pushSpeed = pushNegative;
        } else if (transform.position.x >= 8)
        {

            pushSpeed = pushPositive;
        }
    }

}
