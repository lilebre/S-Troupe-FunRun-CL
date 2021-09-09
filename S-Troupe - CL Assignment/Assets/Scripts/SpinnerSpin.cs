using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerSpin : MonoBehaviour
{
    [SerializeField] float spinSpeed;

    void Update()
    {

        transform.Rotate(Vector2.up * spinSpeed * Time.deltaTime);
    }

}
