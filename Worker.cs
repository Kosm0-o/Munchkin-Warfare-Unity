using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{

    bool isSelected;
    // LayerMask variables can be set to certain layers (for filtering and stuff)
    public LayerMask resourceLayer;
    public float collectDistance;
    Resource currentResource;
    public float timeBetweenCollect;
    float nextCollectTime;
    public int collectAmount;
    public float distanceToAltar;

    GameObject bloodAltar;

    public GameObject resourcePopup;

    // Start is called before the first frame update
    void Start()
    {
        // Good use of tags: 
        bloodAltar = GameObject.FindGameObjectWithTag("Altar");
    }

    // Update is called once per frame
    void Update()
    {
        if (isSelected == true) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            transform.position = mousePos;
        } else {

            if (Vector3.Distance(transform.position, bloodAltar.transform.position) <= distanceToAltar) {
                ResourceManager.instance.AddSacrificedWorker();
                Destroy(gameObject);
            }
            
            // Creates an OverlapCircle(central point, radius, layer) to detect "collisions" with the sprite withholding the script
            Collider2D col = Physics2D.OverlapCircle(transform.position, collectDistance, resourceLayer);
            // if there is a collision and there is no resource currently being collected
            if (col != null && currentResource == null) {
                // currentResource's value is set to the resource that is in the OverlapCircle (col)
                currentResource = col.GetComponent<Resource>(); 
            } else {
                // if there is no collision or a current resource, currentResource is set to null to create a loop via the Update function
                currentResource = null;
            }
            // detects if there is a currentResource (runs after above if/else statement so that currentResource has a chance to store a value)
            if (currentResource != null) {
                // checks if the time of the game is greater than the next time to collect resources
                if (Time.time > nextCollectTime) {
                    Instantiate(resourcePopup, transform.position, Quaternion.identity);
                    nextCollectTime = Time.time + timeBetweenCollect;
                    currentResource.resourceAmount -= collectAmount;
                    ResourceManager.instance.AddResource(currentResource.resourceType, collectAmount);
                }
            }
        }
    } 

    // OnMouseDown is called when mouse is pressed/held
    private void OnMouseDown() 
    {
        isSelected = true;
    }
    
    // OnMouseUp is called when mouse is not pressed or held (usually after a click/press/hold of the mouse)
    private void OnMouseUp()
    {
        isSelected = false;
    }
}
