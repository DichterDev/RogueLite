using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.collider.name != "bullet")
        {
            Destroy(gameObject);
        }
          
    }

}
