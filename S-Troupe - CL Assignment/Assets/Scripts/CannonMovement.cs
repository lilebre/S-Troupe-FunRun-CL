using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    float cannonSpeed;
    void Start()
    {
        cannonSpeed = Random.Range(5f, 13f);
    }

    void Update()
    {
        transform.Translate(1 * cannonSpeed * Time.deltaTime, 0,0);
    }

}
