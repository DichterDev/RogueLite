using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public ProjectileSpammerManager manager;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, manager.SpinSpeed * Time.deltaTime);
    }
}