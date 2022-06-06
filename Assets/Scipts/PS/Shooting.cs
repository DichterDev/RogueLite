
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public ProjectileSpammerManager manager;

    private List<Transform> firePoints = new List<Transform>();

    public float bulletForce = 5f;
    public float bulletTimer = 1f;
    public float shootTimer;

    private void Start()
    {
        foreach (Component component in gameObject.GetComponentsInChildren<Component>())
        {
            if (component.tag == "FirePoint") firePoints.Add(component.transform);
        }
    }

    void FixedUpdate()
    {
            shootTimer += Time.deltaTime;
            if (shootTimer > manager.FireRate)
            {
                shootTimer = 0f;
                Shoot();
            }
    }

    void Shoot()
    {
        foreach (Transform t in firePoints)
        {
            GameObject bullet = Instantiate(manager.Projectile, t.position, t.rotation);
            bullet.name = "bullet";
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(t.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
