using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBullet : MonoBehaviour
{
    public ProjectileManager projectile;
    public GameObject bullet;
    public Rigidbody2D rb;

    private void Start()
    {
        rb.velocity = Vector2.up * projectile.ProjSpeed;
    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * Time.deltaTime * projectile.ProjSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        ContactPoint2D cp = collision.contacts[0];
        Vector2 newDir = Vector2.zero;
        Vector2 curDire = this.transform.TransformDirection(Vector2.up);

        newDir = Vector2.Reflect(curDire, cp.normal);
        transform.rotation = Quaternion.FromToRotation(Vector2.up, newDir);
    }
}
