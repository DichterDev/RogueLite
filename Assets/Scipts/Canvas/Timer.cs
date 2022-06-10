using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float deltaTimer = 0f;
    float timerValue = 1f;

    private void Update()
    {
        deltaTimer += Time.deltaTime;
        if (deltaTimer > 1f)
        {
            gameObject.GetComponent<Text>().text = timerValue + " s";
            deltaTimer = 0f;
            timerValue++;
        }
    }
}
