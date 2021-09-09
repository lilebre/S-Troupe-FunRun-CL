using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonDestroy : MonoBehaviour
{
    //private void OnCollisionEnter(Collision collision)
    //{

    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Debug.Log("collision");
            other.gameObject.SetActive(false);
            Destroy(other.gameObject); 
        }
    }
}
