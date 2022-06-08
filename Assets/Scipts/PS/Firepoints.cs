using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoints : MonoBehaviour
{
    public ProjectileSpammerManager manager;

    float rotation = 360;
    Vector3 tempRot = new Vector3();

    private void Awake()
    {
        rotation = rotation / manager.Firepoints;

        for (int i = 0; i < manager.Firepoints; i++)
        {
            Vector3
            GameObject go = Instantiate(new GameObject());
            go.tag = "FirePoint";
            go.transform.parent = transform;
            go.transform.position = new Vector3(0, 0.5f);

            gameObject.transform.rotation = Quaternion.Euler(tempRot);
        }    
    }
}
