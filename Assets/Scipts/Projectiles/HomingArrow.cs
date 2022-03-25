using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingArrow : MonoBehaviour
{
    public ProjectileManager projectileManager;
    public Rigidbody2D rb;

    private Transform target;

    private float rotationSpeed = 200f;

    private void Start()
    {
        
    }

    private void Update()
    {
        target = GetClosestEnemy(GameObject.FindGameObjectsWithTag("Enemy"));
    }

    void FixedUpdate()
    {
        Vector2 direction = (Vector2)target.position - rb.position;
        direction.Normalize();
        float rotateAmount = Vector3.Cross(direction, transform.up).z;
        rb.angularVelocity = -rotateAmount * rotationSpeed;
        rb.velocity = transform.up * projectileManager.ProjSpeed;
    }

    void Shoot()
    {
        GameObject arrow = Instantiate(projectileManager.Projectile, projectileManager.firePoint.position, projectileManager.firePoint.rotation);
        arrow.name = "Arrow";
        arrow.tag = "Projectile";
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(projectileManager.firePoint.up * projectileManager.ProjForce, ForceMode2D.Impulse);
    }

    /// <summary>
    /// Method <c>GetClosestEnemy</c> gets the nearest target
    /// <see href="https://forum.unity.com/threads/clean-est-way-to-find-nearest-object-of-many-c.44315/">Source</see>
    /// </summary>
    /// <param name="enemies"></param>
    /// <returns></returns>
    Transform GetClosestEnemy(GameObject[] enemies)
    {   
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (GameObject potentialTarget in enemies)
        {
            Vector3 directionToTarget = potentialTarget.transform.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget.transform;
            }
        }

        return bestTarget;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) Destroy(gameObject);
        else if (!collision.gameObject.CompareTag("Projectile")) Destroy(gameObject);
        else Destroy(gameObject);
    }
}
