/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase1 : MonoBehaviour
{
    public Boss1 bossPhases;
    public GameObject bossPhase2;
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletTimer = 5f;
    public float bulletForce = 5f;

    private float nextTimeToShoot = 0f;
    private float fireRate = 5f;

    private float bossHP;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bossHP = bossPhases.bossHP;

        if (bossHP <= 50)
        {
            gameObject.SetActive(false);
            bossPhase2.SetActive(true);
            Debug.Log("Phase2");
        }
        else
        {
            BossPhase();
        }

    }

    private void BossPhase()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 60f);

        if (Time.time >= nextTimeToShoot)
        {
            Shoot(firePoint);
        }
    }

    private void Shoot(Transform fp)
    {
        GameObject bullet = Instantiate(bulletPrefab, fp.position, fp.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(fp.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, bulletTimer);

        nextTimeToShoot = Time.time + 1f / fireRate;
    }
}
*/