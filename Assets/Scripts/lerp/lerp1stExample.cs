using System;
using TMPro;
using UnityEngine;

public class lerp1stExample : MonoBehaviour
{
    float startingValue = 0f;
    float EndingValue = 10f;
    float changingDuration = 4f;

    float timePast;
    float lerpValue;

    int toDisplayOnScreen;
    public TMP_Text myNumbersOnScreen;

    void Update()
    {
        lerpValue = Mathf.Lerp(startingValue, EndingValue, timePast / changingDuration);
        timePast += Time.deltaTime;

        toDisplayOnScreen = (int)lerpValue;
        myNumbersOnScreen.text = toDisplayOnScreen.ToString() + "  Changing numbers";
    }
}