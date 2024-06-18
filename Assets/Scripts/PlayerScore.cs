using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] public static float totalScore;
    public TextMeshProUGUI scoreText;
    public bool reset = false;
    void Start()
    {
        if(reset){
            totalScore = 0;
        }
    }


    void Update()
    {
        //Debug.Log("Score = " + totalScore);
        scoreText.text = "Score: " + totalScore;
    }

    public void AddScore(float score){
        totalScore += score;
        //Debug.Log("Total Score:" + totalScore);
    }
}
