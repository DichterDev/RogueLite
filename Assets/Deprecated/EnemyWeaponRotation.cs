using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponRotation : MonoBehaviour
{
    public Rigidbody2D rb;

    Vector2 playerPos;

    // Update is called once per frame
    void Update()
    {
        playerPos = rb.position;
    }

    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, playerPos) < 20f)
        {
            Vector2 lookDir = playerPos - (Vector2)transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = rotation;
        }
    }
}
