using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spammer", fileName = "Manager", order = 1)]
public class ProjectileSpammerManager : ScriptableObject
{
    public GameObject Projectile; // Projectile Prefab

    public int Firepoints; // Number of Firepoints
    public int ProjDamage; // Damage of Projectile
    public float ProjSpeed; // Travel speed of Projectile
    public float ProjForce; // Initital Force of Projectile
    public float ProjTime; // absolute time until destruction of Projectile
    public float FireRate; // Projectiles per Second
    public int SpinSpeed; // Degrees per Second
}