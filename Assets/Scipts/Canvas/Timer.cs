using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float deltaTimer = 0f;
    public float timerStandardValue = 20f;
    public float timerValue = 0f;

    private void Awake()
    {
        timerValue = timerStandardValue;
        gameObject.GetComponent<Text>().text = timerValue + " s";
    }

    private void Update()
    {
        deltaTimer += Time.deltaTime;
        if (deltaTimer >= 1f)
        {
            timerValue--;
            gameObject.GetComponent<Text>().text = timerValue + " s";
            deltaTimer = 0f;
        }

        if (timerValue == 0f)
        {

            if (GameObject.FindObjectOfType<Camera>().GetComponent<RoomManager>().count == 7) SceneManager.LoadScene(2);

            timerValue = timerStandardValue;
            GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(0, -4, 1);
            // Reinstantiate current room
            GameObject.FindObjectOfType<Camera>().GetComponent<RoomManager>().NextRoom();        
        }
    }

    public void SetTimerValue(float timer)
    {
        timerValue = timer;
        gameObject.GetComponent<Text>().text = timerValue + " s";
    }
}