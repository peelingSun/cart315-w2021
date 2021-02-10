using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap
{
    private int trapID = 1;
    public int TrapID { get { return trapID; } }
    private float trapDamage = 10.0f;
    public float TrapDamage { get { return trapDamage; } set { trapDamage = value; } }
    private float trapEffectRadius = 5.0f;
    public float TrapEffectRadius { get { return trapEffectRadius; } set { trapEffectRadius = value; } }
    private int sizeInInventory = 1;
    public int SizeInInventory { get { return sizeInInventory; } }
}
