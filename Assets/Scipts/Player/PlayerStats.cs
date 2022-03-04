using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Rigidbody2D rb;

    public int CurrentHP = 10;
    public int MaxHP = 10;
    public float Velocity = 5f;
    public float MaxVelocity = 10f;
    public float CritChance = 5f;
    public float CritMultiplier = 1f;
    public int Coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHP > MaxHP) CurrentHP = MaxHP;
        else if (CurrentHP <= 0) Destroy(gameObject);
    }
}
