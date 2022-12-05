using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);

    public float delayTime = 1.5f;
    public float repeatTime = 2;

    void Start()
    {
        InvokeRepeating("ObstacleSpawn", delayTime, repeatTime);
    }


    void Update()
    {
    }

    void ObstacleSpawn()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
