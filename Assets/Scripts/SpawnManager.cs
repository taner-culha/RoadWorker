using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllers;
    void Start()
    {
        playerControllers = GameObject.Find("RoadWorker_Black").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle",startDelay,repeatRate);
    }
    void SpawnObstacle()
    {
        if (playerControllers.gameOver==false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

        }
    }
}
