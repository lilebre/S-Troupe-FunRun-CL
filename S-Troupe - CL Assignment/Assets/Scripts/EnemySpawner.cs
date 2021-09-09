using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject cannonBall;
    float randZ;
    Vector3 whereToSpawn;
    public float spawnRate = 2f;

    float nextSpawn = 0f;


    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randZ = Random.Range(75f, 150f);
            whereToSpawn = new Vector3(transform.position.x, transform.position.y, randZ);
            Instantiate(cannonBall, whereToSpawn, Quaternion.identity);
        }
    }
}
