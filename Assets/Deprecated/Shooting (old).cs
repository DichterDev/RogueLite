/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 5f;
    public float bulletTimer = 5f;
    public float shootTimer;
    public float coolDownTime = 0.1f;

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
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bullet.name = "bullet";
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, bulletTimer);
        
    }

   

   

}
*/