using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    GameObject[] rooms;
    int count = 0;

    private void Awake()
    {
        rooms = GameObject.FindGameObjectsWithTag("Room");
    }

    void Start()
    {
        for (int i = rooms.Length - 1; i > 0; i--)
        {
            rooms[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RoomReset()
    {
        GameObject room = GameObject.FindGameObjectWithTag("Room");

        foreach(Transform child in transform)
        {

        }

    }

    public void NextRoom()
    {
        foreach(GameObject proj in GameObject.FindGameObjectsWithTag("Projectile"))
        {
            Destroy(proj);
        }

        rooms[count].SetActive(false);
        count++;
        rooms[count].SetActive(true);
    }
}
