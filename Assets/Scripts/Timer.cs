using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
	public TextMeshProUGUI timerText;
	public static float secondsCount;
    public bool pause = false;
    public bool reset = false;

    void Update(){
       
        UpdateTimerUI();
        if(reset){
            secondsCount = 0;
        }
    }

    public void UpdateTimerUI(){
        if(!pause){
		secondsCount += Time.deltaTime;
        }
		timerText.text = "Time: "+(int)secondsCount + "s";
	}
}
