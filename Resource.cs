using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour
{
    public string resourceType;
    public int resourceAmount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (resourceAmount <= 0) {
            Destroy(gameObject);
        }
    }
}
