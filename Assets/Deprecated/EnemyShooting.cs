using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject target;

    public float bulletForce = 5f;
    public float bulletTimer = 5f;
    public float fireRate = 5f;

    private float nextTimeToShoot = 0f;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, target.transform.position) < 20f && Time.time >= nextTimeToShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, bulletTimer);

        nextTimeToShoot = Time.time + 1f / fireRate;
    }
}