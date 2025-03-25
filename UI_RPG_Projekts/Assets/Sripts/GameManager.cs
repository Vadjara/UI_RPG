using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private Enemy enemyPrefabBerserker;
    [SerializeField] private Enemy enemyPrefabMage;

    [SerializeField] private Sprite berserkerSprite;
    [SerializeField] private Sprite mageSprite;
    [SerializeField] private Image enemyImage;

    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyHealth;
    [SerializeField] private GameObject gameOverPanel; 

    private Enemy currentEnemy;
    

    void Start()
    {
        gameOverPanel.SetActive(false); 
        SpawnNewEnemy();
        RefreshUI();
    }

    void SpawnNewEnemy()
    {
        if (Random.value > 0.5f)
        {
            currentEnemy = Instantiate(enemyPrefabBerserker);
            enemyImage.sprite = berserkerSprite;
        }
        else
        {
            currentEnemy = Instantiate(enemyPrefabMage);
            enemyImage.sprite = mageSprite;
        }

        RefreshUI();
    }

    public void DoRound()
    {
        currentEnemy.TakeDamage(player.ActiveWeapon);

        if (currentEnemy.health <= 0)
        {
            SpawnNewEnemy();
            return;
        }

        int enemyDamage = currentEnemy.Attack();
        player.TakeDamage(enemyDamage);

        if (player.health <= 0)
        {
            GameOver();
            return;
        }

        RefreshUI();
    }

    public void RefreshUI()
    {
        playerName.text = player.CharName;
        playerHealth.text = "Health: " + player.health.ToString();

        if (currentEnemy != null)
        {
            enemyName.text = currentEnemy.name;
            enemyHealth.text = "Health: " + currentEnemy.health.ToString();
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
        gameOverPanel.SetActive(true); 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}
