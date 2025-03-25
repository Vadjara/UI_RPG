using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Berserker : Enemy
{
    [SerializeField] private int aggressionGain = 10;

    public override int Attack()
    {
        agression += aggressionGain;
        Debug.Log(name + " attacks wildly!");
        return ActiveWeapon.GetDamage() + agression / 10;
    }
}
