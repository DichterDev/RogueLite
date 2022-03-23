using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingArrow : MonoBehaviour
{
    public ProjectileManager projectileManager;

    private void Start()
    {
        
    }

    void FixedUpdate()
    {

    }

    void Shoot()
    {
        GameObject arrow = Instantiate(projectileManager.Projectile, projectileManager.firePoint.position, projectileManager.firePoint.rotation);
        arrow.name = "Arrow";
        if (UserType) arrow.tag = "Projectile";
        else arrow.tag = "EnemyProjectile";
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(projectileManager.firePoint.up * projectileManager.ProjForce, ForceMode2D.Impulse);
    }

    // https://forum.unity.com/threads/clean-est-way-to-find-nearest-object-of-many-c.44315/ gestackoverflowed
    Transform GetClosestEnemy(Transform[] enemies)
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in enemies)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }

        return bestTarget;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) Destroy(gameObject);
        else if (!collision.gameObject.CompareTag("Projectile")) Destroy(gameObject);
    }
}
