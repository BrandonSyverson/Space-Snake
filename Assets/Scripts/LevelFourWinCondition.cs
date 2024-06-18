using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFourWinCondition : MonoBehaviour
{
    public static float snakesKilled = 0;
    public float numberOfSnakes = 30;
    public static bool levelFiveLoaded = false;

    void Start()
    {
        
    }


    void Update()
    {
        //Debug.Log(snakesKilled);
        if(snakesKilled == numberOfSnakes && levelFiveLoaded == false){
            levelFiveLoaded = true;
            Debug.Log(snakesKilled);
            //SceneManager.LoadScene(3);
        }
    }
}
