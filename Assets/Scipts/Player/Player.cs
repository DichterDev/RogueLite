using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject equippedWeapon;
    public Transform weaponTransform;

    public int CurrentHP = 10;
    public int MaxHP = 10;
    public float Velocity = 5f;
    public float MaxVelocity = 10f;
    public float CritChance = 5f;
    public float CritMultiplier = 1f;
    public int Coins = 0;

    public abstract void Apply(GameObject gameObject);
}
