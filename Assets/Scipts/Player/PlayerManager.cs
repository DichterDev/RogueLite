using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject equippedWeapon;
    public Transform weaponTransform;

    public int CurrentHP = 10;
    public int MaxHP = 10;
    public float Speed = 5f;
    public float MaxSpeed = 10f;
    public float CritChance = 0.05f;
    public float CritMultiplier = 1.25f;
    public int Coins = 0;
    public float attackSpeed = 1.0f;
    public float Strength = 1.0f;

    public void TakeDamage(int amount)
    {
        CurrentHP -= amount;

        if (CurrentHP <= 0)
        {
            //Death
        }
    }

    public void Heal(int amount)
    {
        CurrentHP += amount;

        if (CurrentHP > MaxHP) CurrentHP = MaxHP;
    }
}
