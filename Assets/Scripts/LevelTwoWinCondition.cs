using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTwoWinCondition : MonoBehaviour
{
    public static float snakesKilled = 0;
    public float numberOfSnakes = 15;
    public static bool levelThreeLoaded = false;
    void Start()
    {
        
    }


    void Update()
    {
        Debug.Log(snakesKilled);
        if(snakesKilled == numberOfSnakes && levelThreeLoaded == false){
            levelThreeLoaded = true;
            //SceneManager.LoadScene(4);
        }
    }
}
