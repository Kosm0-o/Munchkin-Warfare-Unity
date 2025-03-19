using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
`   int value = 0;
    public Transform[] children;
    public GameObject[] childrenObj;
  
    // Start is called before the first frame update
    void Start()
    {
      children = GetComponentInChildren<Transform>();
      childrenObj = new GameObject[children.length];

      foreach(Transform t in children) {
        value++;
        childrenObj.SetValue(t.gameObject, value - 1);
      }
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
      
      }
      
      if (button == "Credits") {
      
      } 
      if (button == "Exit") {
          Application.Quit();
      }
      
    }

    
}
