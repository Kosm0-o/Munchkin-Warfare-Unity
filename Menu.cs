using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  
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
    
    }
    
    public void onMenuClick(string button) 
    {
      if (button == "Play") {
          SceneManager.LoadScene("Main Game");
      } 
      if (button == "Instructions") {
          SceneManager.LoadScene("Instructions");
      }
      
      if (button == "Credits") {
          SceneManager.LoadScene("Credits");
      } 
      if (button == "Exit") {
          Application.Quit();
      }
      
    }

    
}
