using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [SerializeField] private string charName;
    [SerializeField] private AudioClip healSound;
    protected AudioClip attackSound;
    public string CharName
    {
        get { return charName; }
    }

    private bool isShieldActive = false;
    private int shieldDurability = 3; 
    private int roundCounter = 0; 
    private int healAmount = 20; 

    public void ToggleShield()
    {
        isShieldActive = !isShieldActive;
        Debug.Log("Shield " + (isShieldActive ? "Activated" : "Deactivated"));
    }

    public override void TakeDamage(int damage)
    {
        Debug.Log(name + " health before hit: " + health);

        if (isShieldActive)
        {
            damage /= 2;
            shieldDurability--;

            Debug.Log("Shield absorbed damage! Remaining durability: " + shieldDurability);

            if (shieldDurability <= 0)
            {
                isShieldActive = false;
                Debug.Log("Shield broke!");
            }
        }

        health -= damage;
        Debug.Log(name + " Health after hit: " + health);
        
        roundCounter++; 
    }

    public void Heal()
    {
        if (roundCounter >= 3)
        {
            health += healAmount;
            Debug.Log("Player healed for " + healAmount + " HP!");
            roundCounter = 0; 


            AudioManager.instance.PlaySoundEffect(healSound);

            FindObjectOfType<GameManager>().RefreshUI();
        }
        else
        {
            Debug.Log("Heal not ready yet! " + (3 - roundCounter) + " rounds left.");
        }
    }
    public override int Attack()
    {
        if (attackSound != null)
        {
            AudioManager.instance.PlaySoundEffect(attackSound);
        }
        return ActiveWeapon.GetDamage();
    }
}