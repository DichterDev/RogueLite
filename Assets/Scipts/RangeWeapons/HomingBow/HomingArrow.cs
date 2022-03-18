using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingArrow : MonoBehaviour
{
    private HomingBow homingBow;
    private float ArrowRotationSpeed, ArrowDamage, ArrowCritChance, ArrowCritMultiplier, ArrowForce;

    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        homingBow = GetComponent<HomingBow>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {

        }
    }
}
