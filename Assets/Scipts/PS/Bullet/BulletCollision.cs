using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public ProjectileSpammerManager manager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(tag))
        {
            // Physics2D.IgnoreCollision(collision.collider.GetComponent<CircleCollider2D>(), collision.otherCollider.GetComponent<CircleCollider2D>());
            Physics2D.IgnoreLayerCollision(3, 3);
            return;
        }
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<PlayerManager>().TakeDamage(manager.ProjDamage);
        }

        Destroy(gameObject);
    }
}