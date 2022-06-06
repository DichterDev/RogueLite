using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spammer", fileName = "Manager", order = 1)]
public class ProjectileSpammerManager : ScriptableObject
{
    public GameObject Projectile;

    public int ProjDamage;
    public float ProjSpeed;
    public float ProjForce;
    public float ProjTime;
    public float FireRate;
}