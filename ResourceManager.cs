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

    private void Awake() 
    {
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

    public void AddSacrificedWorker()
    {
        numberOfWorkersSacrificed++;
        sacrificedText.text = numberOfWorkersSacrificed + " / " + sacrificeGoal;

        if (numberOfWorkersSacrificed >= sacrificeGoal) {
            print("You win!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
