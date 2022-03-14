using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 5f;
    public float bulletTimer = 5f;
    public float shootTimer;
    public float coolDownTime = 0.5f;

    void FixedUpdate()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer > coolDownTime && Input.GetButton("Fire1"))
        {
            shootTimer = 0f;

            Shoot();
        }
    }

    void Shoot()
    {
        GameObject arrow = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        arrow.name = "arrow";
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(arrow, bulletTimer);

    }
}
