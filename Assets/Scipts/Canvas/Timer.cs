using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float deltaTimer = 0f;
    float timerValue = 20f;

    GameObject[] rooms;
    int roomsCount = 0;

    private void Awake()
    {
        rooms = GameObject.FindGameObjectsWithTag("Room");
        Debug.Log(rooms.Length);
    }

    private void Update()
    {
        deltaTimer += Time.deltaTime;
        if (deltaTimer >= 1f)
        {
            gameObject.GetComponent<Text>().text = timerValue + " s";
            deltaTimer = 0f;
            timerValue--;
        }

        if (timerValue == 0)
        {
            timerValue = 20f;
            GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(0, -4, -1);
            // Reinstantiate current room
            GameObject.Find("Background").GetComponent<RoomManager>().NextRoom();
        }
    }

    void NextRoom()
    {
        GameObject room = GameObject.FindGameObjectWithTag("Room");
        Destroy(room);
        Instantiate(rooms[roomsCount]);
    }
}
