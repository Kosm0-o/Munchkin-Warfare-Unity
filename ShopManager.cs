using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{

    public Ghost worker;
    public Ghost tree;
    public Ghost crystal;
    public Ghost village;
    public Ghost trap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onShopClick(string item) 
    {   
        if (item == "worker") {
            Instantiate(worker);
        }
        if (item == "tree") {
            Instantiate(tree);
        }
        if (item == "crystal") {
            Instantiate(crystal);
        }
        if (item == "village") {
            Instantiate(village);
        }
        if (item == "trap") {
            Instantiate(trap);
        }
    }
}
