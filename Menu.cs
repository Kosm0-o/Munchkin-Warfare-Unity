using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public Transform[] children;
    public GameObject[] childrenObj;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void destroyUI() 
    {
        foreach (
    }
    
    public void onMenuClick(string button) 
    {
      if (button == "Play") {
          SceneManager.LoadScene("Main Game");
      } 
      if (button == "Instructions") {
      
      }
      
      if (button == "Credits") {
      
      } 
      if (button == "Exit") {
          Application.Quit();
      }
      
    }

    
}
