using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    public float speed;
    public float minX, maxX, minY, maxY;

    Vector3 currentTarget;
    public GameObject bloodPrefab;
    // Start is called before the first frame update
    void Start()
    {
        currentTarget = GetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, currentTarget) > 0.5f) {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);
        } else {
            currentTarget = GetRandomPosition();
        }
    }

    // GetRandomPosition returns a random Vector3 pos
    Vector3 GetRandomPosition() 
    {
        Vector3 randomPos = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
        return randomPos;
    }
    //OnTriggerEnter2D detects collisions between the Enemy and other specified game objects
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Altar") {
            // restart original scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (collision.tag == "Trap") {
            //Instantiate blood, destroy trap/enemy
            Destroy(collision.gameObject);
            Instantiate(bloodPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
