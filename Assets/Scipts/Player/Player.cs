using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject equippedWeapon;
    public Transform weaponTransform;
    public HealthBar healthBar;

    public int CurrentHP = 10;
    public int MaxHP = 10;
    public int Coins = 0;

    public float Speed = 5f;
    public float MaxSpeed = 10f;
    
    public float CritChance = 0.05f;
    public float CritMultiplier = 1.25f;
    
    public float attackSpeed = 1.0f;
    public float Strength = 1.0f;

    private int deltaMaxHP;

    private void Awake()
    {
        deltaMaxHP = MaxHP;
    }
    private void Start()
    {
        
    }

    private void Update()
    {
        if (CurrentHP > MaxHP) CurrentHP = MaxHP;
        if (Speed > MaxSpeed) Speed = MaxSpeed;
        if (deltaMaxHP != MaxHP)
        {
            healthBar.SetMaxHealth(MaxHP);
            deltaMaxHP = MaxHP;
        }

        healthBar.SetHealth(CurrentHP);
    }
}
