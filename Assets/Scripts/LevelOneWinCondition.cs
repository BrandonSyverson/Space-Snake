using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelOneWinCondition : MonoBehaviour
{
    public static float snakesKilled = 0;
    public float numberOfSnakes = 10;
    public static bool levelTwoLoaded = false;

    void Start()
    {
        
    }


    void Update()
    {
        //Debug.Log(snakesKilled);
        Debug.Log(snakesKilled);
        if(snakesKilled == numberOfSnakes && levelTwoLoaded == false){
            levelTwoLoaded = true;
            //SceneManager.LoadScene(3);
        }
    }

    void Reset(){
        Debug.Log("Reset");
    }
}
