using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_HealthBoost : ItemBuffEffect
{
    /// <summary>
    /// Adds Health to the Player
    /// </summary>

    public int amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<Player>().CurrentHP += amount;
    }
}
