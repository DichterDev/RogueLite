using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Projectiles", fileName = "Manager", order = 1)]
public class ProjectileManager : ScriptableObject
{
    public Transform firePoint;
    public GameObject Projectile;

    public int Damage;
    public float ProjSpeed;
    public float ProjForce;
    public float ProjTime;
}
