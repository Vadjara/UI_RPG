using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private Character character;
    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyHealth;
    // Start is called before the first frame update
void Start()
    {
        RefreshUI();
    }

public void DoRound()
{
    //int playerDamage = player.Attack();
    //enemy.TakeDamage(playerDamage);
    enemy.TakeDamage(player.ActiveWeapon);
    int enemyDamage = enemy.Attack();
    player.TakeDamage(enemyDamage);
    RefreshUI();
}

public void RefreshUI()
{
    playerName.text = player.CharName;
    enemyName.text = enemy.name;
    playerHealth.text ="health: " + player.health.ToString();
    enemyHealth.text = "health: " + enemy.health.ToString();
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
