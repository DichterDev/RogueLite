using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_StrBoost : ItemBuffEffect
{
    /// <summary>
    /// Adds Strength to the Player
    /// </summary>

    public float amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<Player>().Strength += amount;
    }
}
