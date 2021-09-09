using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEnemySpawner : MonoBehaviour
{
    public GameObject jumpSpawn;
    Vector3 whereToSpawn;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("trigger");
            whereToSpawn = new Vector3(other.transform.position.x, other.transform.position.y + 2, other.transform.position.z + 8);
            Instantiate(jumpSpawn, whereToSpawn, Quaternion.identity);
        }
    }
}
