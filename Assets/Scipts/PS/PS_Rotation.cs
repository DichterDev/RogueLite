using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PS_Rotation : MonoBehaviour
{
    public int spinSpeed = 45;
    public ProjectileSpammerManager manager;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}
