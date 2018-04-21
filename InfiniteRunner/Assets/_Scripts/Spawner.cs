using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject ground;

    private void Start()
    {
        Spawn();
    }
    
    void Spawn()
    {
        Instantiate(ground, transform.position, Quaternion.identity);
        InvokeRepeating("Spawn", 0.0f, 0.5f);
    }
}
