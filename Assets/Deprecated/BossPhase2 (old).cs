/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPhase2 : MonoBehaviour
{
    public Boss1 boss;
    public GameObject Phase1;
    public GameObject bulletPrefab;
    public SpriteRenderer sr;
    public Sprite sprite;
    public Transform[] firePoints;

    public float bulletTimer = 5f;
    public float bulletForce = 5f;
    public int bossHealth;

    private float nextTimeToShoot = 0f;
    private float fireRate;

    void Start()
    {
        transform.localScale = new Vector3(1.5f, 1.5f, 0);
        sr.sprite = sprite;
        fireRate = boss.fireRate;
    }

    void Update()
    {
        if (!Phase1.activeSelf)
        {
            BossPhase();
            Debug.Log("Shoot2");
        }
    }

    private void BossPhase()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * 60f);

        if (Time.time >= nextTimeToShoot)
        {
            Debug.Log("Shoot");
            Shoot(firePoints);
            Debug.Log("Shoot1");
        }
    }

    private void Shoot(Transform[] firePoints)
    {
        foreach(Transform fp in firePoints)
        {
            GameObject bullet = Instantiate(bulletPrefab, fp.position, fp.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(fp.up * bulletForce, ForceMode2D.Impulse);
            Destroy(bullet, bulletTimer);
        }

        nextTimeToShoot = Time.time + 1f / fireRate;
    }
}
*/