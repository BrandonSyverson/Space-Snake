using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelThreeWinCondition : MonoBehaviour
{
    public static float snakesKilled = 0;
    public float numberOfSnakes = 20;
    public static bool levelFourLoaded = false;

    void Start()
    {
        
    }


    void Update()
    {
        //Debug.Log(snakesKilled);
        if(snakesKilled == numberOfSnakes && levelFourLoaded == false){
            levelFourLoaded = true;
            Debug.Log("All snakes killed on level 3...");
            //SceneManager.LoadScene(3);
        }
    }
}
