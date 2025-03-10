using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ResourceManager : MonoBehaviour
{

    public int wood;
    public int blood;
    public int crystal;

    public TMP_Text woodDisplay;
    public TMP_Text bloodDisplay;
    public TMP_Text crystalDisplay;

    public static ResourceManager instance;
    public int numberOfWorkersSacrificed;
    public TMP_Text sacrificedText;
    public int sacrificeGoal;

    // Awake is called before Start
    private void Awake() 
    {
    /* instance' value is this (this refers to the current script/class)
       This instance allows other scripts to reference to things in this script(functions, variables, etc.)
       Refer to the class (Resource Manager) then the instance [ResourceManager.instance]
    */
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // AddResource stores new resources taken from the workers
    public void AddResource(string resourceType, int amount) 
    {
        if (resourceType == "Wood") {
            wood += amount;
            woodDisplay.text = wood.ToString();
        }
        if (resourceType == "Blood") {
            blood += amount;
            bloodDisplay.text = blood.ToString();
        }
        if (resourceType == "Crystal") {
            crystal += amount;
            crystalDisplay.text = crystal.ToString();
        }
    }

    // AddSacrificedWorker stores new workers sacrificed into the blood altar
    public void AddSacrificedWorker()
    {
        numberOfWorkersSacrificed++;
        sacrificedText.text = numberOfWorkersSacrificed + " / " + sacrificeGoal;

        // detects when the workers sacrificed is equal to the sacrifice
        if (numberOfWorkersSacrificed >= sacrificeGoal) {
            print("You win!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
