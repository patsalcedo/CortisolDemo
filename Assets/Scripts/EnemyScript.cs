using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject ghost;
    private float spawnTime;
    
    // Start is called before the first frame update
    void Start()
    {
        if (Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + .5f;
        }
    }

    void Spawn()
    {
        Instantiate(ghost, transform.position, transform.rotation);
    }
}
