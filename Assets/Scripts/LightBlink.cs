using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlink : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color yellowColor = Color.yellow;
    public Color greyColor = Color.grey;
    public float switchInterval = 2f; 
    public float color1time = 2f;
    public float color2time = 2f;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine(SwitchColorRoutine());
    }

    private System.Collections.IEnumerator SwitchColorRoutine()
    {
        while (true)
        {
            // Switch to yellow
            spriteRenderer.color = yellowColor;
            yield return new WaitForSeconds(switchInterval / color1time);

            // Switch to grey
            spriteRenderer.color = greyColor;
            yield return new WaitForSeconds(switchInterval / color2time);
        }
    }
}