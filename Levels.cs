using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{

    public int levelNum;
    public string levelType;
    public static Levels instance;
    /*
    Level 1: Intro (Basic Mechanics, Slow Enemies)
    Level 2: Enemy Upgrade (A Little Bit Faster Normal Enemies, New Slow/Fat Enemies with More Health)
    Level 3: Enemy Upgrade (Normal Enemies are Really Fast)
    Level 4: Difficulty Upgrade (Big Time Goal Leap/Sacrifice Goal Leap
    Level 5: Insane 
    */
    public int[] survivalTime = new int[] {120, 240, 480, 1250};
    public int[] sacrificeGoal = new int[] {10, 25, 45, 55, 100};


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
        if (levelType == survival) {
            if (Time.time < survivalTime[levelNum]) {
                levelNum ++;
            }
        } 
        else if (levelType == sacrifice) {
            if () {
            
            }
        }
    }

    private string LevelTypeChecker() 
    {
        if ()
    }

    private void levelUp() {
    
    }
    
}
