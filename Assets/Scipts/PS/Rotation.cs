using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    ProjectileSpammerManager manager;

    private void Awake()
    {
        manager = GetComponent<Shooting>().manager;
    }

    void Update()
    {
        gameObject.transform.Rotate(0, 0, manager.SpinSpeed * Time.deltaTime);
    }
}
