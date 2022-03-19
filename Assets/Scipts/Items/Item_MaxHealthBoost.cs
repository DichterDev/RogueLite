using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_MaxHealthBoost : ItemBuffEffect
{
    /// <summary>
    /// Adds MaxHealth to the Player
    /// </summary>

    public int amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerManager>().CurrentHP += amount;
    }
}
