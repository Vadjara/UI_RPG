using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] private Weapon activeWeapon;
    [SerializeField] private AudioClip attackSound;

    public Weapon ActiveWeapon
    {
        get { return activeWeapon; }
    }

    public virtual int Attack()
    {
        if (attackSound != null)
        {
            AudioManager.instance.PlaySoundEffect(attackSound);
        }
        return activeWeapon.GetDamage();
    }

    public virtual void TakeDamage(int damage) 
    {
        Debug.Log(name + " health before hit: " + health);
        health -= damage;
        Debug.Log(name + " Health after hit: " + health);
    }

    public void TakeDamage(Weapon weapon)
    {
        Debug.Log(name + " health before hit: " + health);
        health -= weapon.GetDamage();
        weapon.ApplyEffect(this);
        Debug.Log(name + " Health after hit: " + health);
    }
}
