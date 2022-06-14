using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spammer", fileName = "Manager", order = 1)]
public class ProjectileSpammerManager : ScriptableObject
{
    public GameObject Projectile; // Projectile Prefab

    public int Firepoints = 4; // Number of Firepoints
    public int ProjDamage = 1; // Damage of Projectile
    public float ProjSpeed = 5; // Travel speed of Projectile
    public float ProjForce = 5; // Initital Force of Projectile
    public float ProjTime = 5; // absolute time until destruction of Projectile
    public float FireRate = 5; // Projectiles per Second
    public int SpinSpeed = 90; // Degrees per Second
}