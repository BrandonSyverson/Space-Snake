using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fade : MonoBehaviour
{
    public float fadeInTime = 1.0f;
    public float waitTime = 2.0f;
    public float fadeOutTime = 1.0f;

    public TextMeshProUGUI text;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        StartCoroutine(FadeInOutRoutine());
    }

    IEnumerator FadeInOutRoutine()
    {
        yield return FadeText(true);
        yield return new WaitForSeconds(waitTime);
        yield return FadeText(false);
    }

    IEnumerator FadeText(bool fadeIn)
    {
        float targetAlpha = fadeIn ? 1.0f : 0.0f;
        float startAlpha = text.color.a;
        float elapsedTime = 0.0f;

        while (elapsedTime < (fadeIn ? fadeInTime : fadeOutTime))
        {
            float alpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / (fadeIn ? fadeInTime : fadeOutTime));
            text.color = new Color(text.color.r, text.color.g, text.color.b, alpha);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        text.color = new Color(text.color.r, text.color.g, text.color.b, targetAlpha);
    }
}