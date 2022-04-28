using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstacles;

    private float spawnRangeXFrom = -10;
    private float spawnRangeXTo = 10;
    private float spawnRangeZFrom = 0;
    private float spawnRangeZTo = 170;
    private float startDelay = 0.5f;
    private float spawnInterval = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        // Repeatedly calls SpawnRandomObject
        InvokeRepeating("SpawnRandomObject", startDelay, spawnInterval);
    }

    // Spawns in random objects with a random position and rotation
    void SpawnRandomObject()
    {
        int objectIndex = Random.Range(0, obstacles.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(spawnRangeXFrom, spawnRangeXTo), 10, Random.Range(spawnRangeZFrom, spawnRangeZTo));
        Quaternion spawnRotation = new Quaternion(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360), 0);
        Instantiate(obstacles[objectIndex], spawnPosition, spawnRotation);
    }
}
