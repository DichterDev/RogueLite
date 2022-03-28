using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Bows")]
public class BowManager : ScriptableObject
{
    public GameObject[] firePoints;
    public float DrawTime;
    public float Damage;
    public float ArrowForce;
}
