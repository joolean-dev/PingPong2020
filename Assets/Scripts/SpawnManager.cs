using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = 1;
    private float spawnLimitXRight = -1;
    private float spawnPosY = 15;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random powerup index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate powerup at random spawn location
        int random = Random.Range(0,3);
        Instantiate(ballPrefabs[random], spawnPos, ballPrefabs[random].transform.rotation);
    }
}
