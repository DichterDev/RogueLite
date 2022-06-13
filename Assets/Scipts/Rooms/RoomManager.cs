using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    GameObject[] rooms;
    int count = 0;
    bool pause = false;

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
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || !pause) pause = false;
        if (pause) Time.timeScale = 0;
        if (!pause) Time.timeScale = 1;
    }

    public void RoomReset()
    {
        foreach (GameObject proj in GameObject.FindGameObjectsWithTag("Projectile"))
        {
            Destroy(proj);
        }

        foreach (GameObject child in transform)
        {
            if (child.name == "PS")
            {
                child.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
        pause = true;
    }

    public void NextRoom()
    {
        foreach (GameObject proj in GameObject.FindGameObjectsWithTag("Projectile"))
        {
            Destroy(proj);
        }

        rooms[count].SetActive(false);
        count++;
        rooms[count].SetActive(true);
        pause = true;
    }
}
