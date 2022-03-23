using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public bool UserType;

    private float ArrowForce;
    private float BowDrawtime;
    private float shootTimer;

    private void Start()
    {
        
    }

    void FixedUpdate()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer > BowDrawtime && Input.GetButton("Fire1"))
        {
            shootTimer = 0f;

            Shoot();
        }
    }

    void Shoot()
    {
        GameObject arrow = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        arrow.name = "Arrow";
        if (UserType) arrow.tag = "Projectile";
        else arrow.tag = "EnemyProjectile";
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * ArrowForce, ForceMode2D.Impulse);
        Destroy(arrow, 3f);
    }
}
