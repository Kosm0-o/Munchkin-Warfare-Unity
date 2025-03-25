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
    Level 4: Difficulty Upgrade (Big Time Goal Leap/Sacrifice Goal Leap)
    Level 5: Insane (Max speed normal enemies, max health tank enemies, new rare enemy reviver enemy)
    */
    private int[] survivalTime = new int[] {120, 240, 480, 1250};
    private int[] sacrificeGoal = new int[] {10, 25, 45, 55, 100};

    private string levelType;


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

    private void onGameModeClick(string gameMode) 
    {
        levelType = gameMode;
    }

    private void levelUp() {
        
    }
    
}
