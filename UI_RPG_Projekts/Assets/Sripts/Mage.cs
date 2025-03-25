using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Enemy
{
    [SerializeField] private int magicDamage = 8; // Maģiskais bojājums
    [SerializeField] private float ignoreArmorPercentage = 0.3f; // Ignorē 30% bruņu

    public override int Attack()
    {
        Debug.Log(name + " casts a spell!");
        return Mathf.RoundToInt(magicDamage + (agression * ignoreArmorPercentage));
    }
}
