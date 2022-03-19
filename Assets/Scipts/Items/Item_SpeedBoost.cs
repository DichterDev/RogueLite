using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/SpeedBuff")]
public class ItemSpeedBuff : ItemBuffEffect
{
    /// <summary>
    /// Adds an Speedbuff to the target
    /// </summary>


    public float amount = 5f;
    public override void Apply(GameObject target)
    {
        target.GetComponent<PlayerManager>().Speed += amount;
    }
}