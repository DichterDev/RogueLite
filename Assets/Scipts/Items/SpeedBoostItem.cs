using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/SpeedBuff")]
public class ItemSpeedBuff : ItemBuffEffect
{
    public float amount = 5f;
    public override void Apply(GameObject go)
    {
        go.GetComponent<Player>().Velocity += amount;
    }
}
