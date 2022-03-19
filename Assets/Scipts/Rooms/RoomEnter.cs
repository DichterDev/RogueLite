using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnter : MonoBehaviour
{
    Camera cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cam = FindObjectOfType<Camera>();
            cam.transform.SetParent(gameObject.transform, false);
        }
    }
}
