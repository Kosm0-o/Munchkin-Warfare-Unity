using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButton : MonoBehaviour
{

    public int bloodCost;
    public int woodCost;
    public int crystalCost;
    // MAKE SURE to import the UnityEngine.UI package to create UI variables!
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
    // Gets the button component of the sprite withholding the script
        btn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
    // Ensures buttons are only clickable when the player has enough resources
        if (ResourceManager.instance.blood < bloodCost || ResourceManager.instance.wood < woodCost || ResourceManager.instance.crystal < crystalCost) {
            btn.interactable = false;
        } else {
            btn.interactable = true;
        }
    }

    public void RemoveResources() 
    {
        // negative variables must have space between - and variable [(- cost) not (-cost)]
        ResourceManager.instance.AddResource("Blood", - bloodCost);
        ResourceManager.instance.AddResource("Wood", - woodCost);
        ResourceManager.instance.AddResource("Crystal", - crystalCost);
    }
}
