using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    private float spawnLimitXLeft = -3;
    private float spawnLimitXRight = 3;
    private float spawnPosY = 2; //Altura de caida powerup
    private float spawnLimitZLeft = 1.5f;
    private float spawnLimitZRight = -1.5f;

    //private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
        //playerControllerScript = GameObject.Find("Plane").GetComponent<PlayerController>();
    }

    // Spawn power-ups
    void SpawnObjects()
    {
        // Set random spawn location and random object index
        Vector3 spawnLocation = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, Random.Range(spawnLimitZLeft, spawnLimitZRight));
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        
        Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        
    }
}
