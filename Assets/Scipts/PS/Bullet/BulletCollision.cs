using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public ProjectileSpammerManager manager;

    private void Start()
    {
        Destroy(gameObject, manager.ProjTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(tag)) return;
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<PlayerManager>().TakeDamage(manager.ProjDamage);
        }

        Destroy(gameObject);
    }
}