using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vILLAGE : MonoBehaviour
{

    public GameObject workerPrefab;
    public Transform spawnPoint;
    public float timeBetweenSpawns;
    float nextSpawnTime;

    public int numberOfWorkersToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
