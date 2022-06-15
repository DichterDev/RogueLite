using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoomManager : MonoBehaviour
{
    public GameObject[] rooms;
    public int count = 0;
    bool pause = false;
    Timer timer;
    PlayerManager playerManager;

    private void Awake()
    {
        for (int i = rooms.Length - 1; i > 0; i--)
        {
            rooms[i].SetActive(false);
        }

        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
        playerManager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerManager>();

        Debug.Log(playerManager.CurrentHP);
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
        DestroyProjectiles();
        foreach (Transform child in transform)
        {
            if (child.gameObject.name == "PS")
            {
                child.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            }
        }
        playerManager.SetPosition(new Vector3(0, -5, 1));
        timer.SetTimerValue(timer.timerStandardValue);
        pause = true;
    }

    public void NextRoom()
    {
        DestroyProjectiles();
        rooms[count].SetActive(false);
        count++;
        rooms[count].SetActive(true);

        pause = true;
    }

    public void DestroyProjectiles()
    {
        foreach (GameObject proj in GameObject.FindGameObjectsWithTag("Projectile"))
        {
            Destroy(proj);
        }
    }
}
