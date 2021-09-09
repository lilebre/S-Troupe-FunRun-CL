using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerToFollow;

    public float xOffset;
    public float yOffset;
    public float zOffset;

    public AudioClip trackOne;
    public AudioClip trackTwo;
    AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.position = new Vector3(playerToFollow.position.x + xOffset, playerToFollow.position.y + yOffset, playerToFollow.position.z + zOffset);
        
    }

    public void ChangeToThirdPerson()
    {
        xOffset = 0;
        yOffset = 10;
        zOffset = -6;

        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = 40;
        rotationVector.y = 0;
        rotationVector.z = 0;

        transform.rotation = Quaternion.Euler(rotationVector);
    }

    public void ChangeToFirstPerson ()
    {
        xOffset = 0;
        yOffset = 3;
        zOffset = -1;

        var rotationVector = transform.rotation.eulerAngles;
        rotationVector.x = 0;
        rotationVector.y = 0;
        rotationVector.z = 0;

        transform.rotation = Quaternion.Euler(rotationVector);
    }

    public void PlayTrackOne()
    {
        audioS.Stop();
        audioS.PlayOneShot(trackOne, 1);
        
    }

    public void PlayTrackTwo()
    {
        audioS.Stop();
        audioS.PlayOneShot(trackTwo, 1);
    }
    public void StopMusic()
    {
        audioS.Stop();
    }
}
