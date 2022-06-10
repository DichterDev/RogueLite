using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public Sprite heart_full;
    public Sprite heart_empty;

    public int CurrentHP = 3;
    public int MaxHP = 3;

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
