using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{

    public int bloodCost;
    public int woodCost;
    public int crystalCost;

    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ResourceManager.instance.blood < bloodCost || ResourceManager.instance.wood < woodCost || ResourceManager.instance.crystal < crystalCost) {
            btn.interactable = false;
        } else {
            btn.interactable = true;
        }
    }

    public void RemoveResources() 
    {
        ResourceManager.instance.AddResource("Blood", - bloodCost);
        ResourceManager.instance.AddResource("Wood", - woodCost);
        ResourceManager.instance.AddResource("Crystal", - crystalCost);
    }
}
