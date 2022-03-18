using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public Transform slashPoint;
    public GameObject slashPrefab;

    public float bulletForce = 5f;
    public float bulletTimer = 0.5f;
    public float shootTimer;
    public float coolDownTime = 1f;
    Vector2 mousePos;

    void FixedUpdate()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        shootTimer += Time.deltaTime;
        if (shootTimer > coolDownTime && Input.GetButton("Fire1"))
        {
            shootTimer = 0f;

            Shoot();
        }

        

    }

    void Shoot()
    {
        GameObject slash = Instantiate(slashPrefab, slashPoint.position, slashPoint.rotation);
        slash.name = "slash";
        Rigidbody2D rb = slash.GetComponent<Rigidbody2D>();
        rb.AddForce(slashPoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(slash, bulletTimer);

        Vector2 lookDir = mousePos - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
}
