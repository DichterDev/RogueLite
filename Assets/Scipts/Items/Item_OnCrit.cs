using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_OnCrit : ItemBuffEffect
{
    /// <summary>
    /// Adds an OnCrit effect on the Player
    /// </summary>

    public int amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<Player>().attackSpeed += amount;
    }
}
