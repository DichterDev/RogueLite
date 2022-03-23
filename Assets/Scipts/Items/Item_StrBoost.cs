using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Items/StrenthBoost")]
public class Item_StrBoost : ItemBuffEffect
{
    /// <summary>
    /// Adds Strength to the Player
    /// </summary>

    public float amount;

    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerManager>().Strength += amount;
    }
}
