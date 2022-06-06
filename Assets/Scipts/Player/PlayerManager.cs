using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public HealthBar healthBar;

    public int CurrentHP = 10;
    public int MaxHP = 10;
    public int Coins = 0;
    public int playerSpeed = 10;

    public float Speed = 5f;
    public float MaxSpeed = 10f;

    public float dodgeCD = 1f;
    public bool Dodge = true;
    public float dodgeTime = 0f;

    public void TakeDamage(int damage)
    {
        CurrentHP -= damage;

        // if (CurrentHP <= 0) Death
    }

    public void GainHealth(int amount)
    {
        CurrentHP += amount;
        if (CurrentHP > MaxHP) CurrentHP = MaxHP;
    }
}
