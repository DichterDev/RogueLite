using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBuffEffect : ScriptableObject
{
    public abstract void Apply (GameObject go);
}
