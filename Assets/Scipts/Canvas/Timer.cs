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
        if (deltaTimer >= 1f)
        {
            gameObject.GetComponent<Text>().text = timerValue + " s";
            deltaTimer = 0f;
            timerValue++;
        }

        if (timerValue == 20)
        {
            timerValue = 0f;
            GameObject.FindGameObjectWithTag("Player").transform.localScale = new Vector3(0, -4, -1);
            // Reinstantiate current room
            // countdown and start
        }
    }
}
