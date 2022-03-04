/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss1 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject Phase2;
    public Sprite[] sprites;
    public int maxHP = 100;
    public int bossHP = 100;

    public float bulletTimer = 5f;
    public float bulletForce = 5f;
    public float fireRate = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Phase2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (bossHP <= 0)
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bossHP -= 10;
    }
}
*/