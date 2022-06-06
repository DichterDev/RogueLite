/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform slashPoint;
    public GameObject slashPrefab;

    public float bulletForce = 5f;
    public float bulletTimer = 1f;
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
        GameObject slash = Instantiate(slashPrefab, slashPoint.position, slashPoint.rotation);
        slash.name = "slash";
        Rigidbody2D rb = slash.GetComponent<Rigidbody2D>();
        rb.AddForce(slashPoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(slash, bulletTimer);
        
    }

}
*/