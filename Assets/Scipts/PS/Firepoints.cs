using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firepoints : MonoBehaviour
{
    public ProjectileSpammerManager manager;

    float rotation = 360;
    Vector3 pos = new Vector3();

    private void Start()
    {
        rotation = rotation / manager.Firepoints;
        pos = transform.TransformPoint(new Vector3(0, 0.5f));

        for (int i = 0; i < manager.Firepoints; i++)
        {
            GameObject go = new GameObject();
            go.transform.position = pos;
            go.transform.rotation = Quaternion.Euler(0, 0, 0);
            go.tag = "FirePoint";
            go.transform.parent = transform;

            gameObject.transform.Rotate(0, 0, rotation);
        }
    }
}
