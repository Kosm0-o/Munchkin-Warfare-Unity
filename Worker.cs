using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{

    bool isSelected;
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

            Collider2D col = Physics2D.OverlapCircle(transform.position, collectDistance, resourceLayer);
            if (col != null && currentResource == null) {
                currentResource = col.GetComponent<Resource>(); 
            } else {
                currentResource = null;
            }

            if (currentResource != null) {
                if (Time.time > nextCollectTime) {
                    Instantiate(resourcePopup, transform.position, Quaternion.identity);
                    nextCollectTime = Time.time + timeBetweenCollect;
                    currentResource.resourceAmount -= collectAmount;
                    ResourceManager.instance.AddResource(currentResource.resourceType, collectAmount);
                }
            }
        }
    } 

    private void OnMouseDown() 
    {
        isSelected = true;
    }

    private void OnMouseUp()
    {
        isSelected = false;
    }
}
