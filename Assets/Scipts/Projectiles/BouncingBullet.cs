using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBullet : MonoBehaviour
{
    public ProjectileManager projectile;
    public GameObject bullet;
    public Rigidbody2D rb;

    private Vector3 tempVelocity;

    private void Start()
    {
        rb.velocity = Vector2.up * projectile.ProjSpeed;
    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ContactPoint2D cp = collision.GetContact(0);
    }
}
