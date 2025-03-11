using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vILLAGE : MonoBehaviour
{

    public GameObject workerPrefab;
    // Transform variable are positions, size, or rotations, usually
    public Transform spawnPoint;
    public float timeBetweenSpawns;
    // notice that this is a dependent variable, therefore not public (not accessible in unity)
    float nextSpawnTime;

    public int numberOfWorkersToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // same system as worker script for resource collection
        if (Time.time > nextSpawnTime) {
            nextSpawnTime = Time.time + timeBetweenSpawns;
            Instantiate(workerPrefab, spawnPoint.position, Quaternion.identity);
            numberOfWorkersToSpawn--;

            if(numberOfWorkersToSpawn <= 0) {
                Destroy(gameObject);
            } 
        }
    }
}
