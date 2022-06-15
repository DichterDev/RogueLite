using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenue : MonoBehaviour
{
    bool menue = false;
    public Canvas canvas;

    GameObject[] gameObjects;
    RoomManager rm;
    PlayerManager player;

    private void Awake()
    {
        canvas.enabled = false;
        rm = GetComponent<RoomManager>();
        player = GameObject.Find("Player").GetComponent<PlayerManager>();
    }

    private void Start()
    {
        gameObjects = GameObject.FindObjectsOfType<GameObject>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            menue = !menue;

            if (menue)
            {
                rm.DestroyProjectiles();
                gameObjects = GameObject.FindObjectsOfType<GameObject>();
                Debug.Log("saved gameobjects");
                Time.timeScale = 0;
                ChangeObjects(!menue);
                canvas.enabled = true;
            }
            if (!menue)
            {
                Time.timeScale = 1;
                ChangeObjects(!menue);
                canvas.enabled = false;
                rm.RoomReset();
            }
        }
    }

    void ChangeObjects(bool active)
    {
        try
        {
            foreach (GameObject go in gameObjects)
            {
                if (go == null) continue;
                else if (!go.CompareTag("Untagged") && go != null && !go.CompareTag("Projectile")) go.SetActive(active);
            }
        }
        catch(MissingReferenceException ex)
        {
            Debug.LogException(ex);
        }
    }
}
