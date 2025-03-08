using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private Character character;
    // Start is called before the first frame update
    void Start()
    {
        player.ReportHealth();
        Debug.Log(player.CharName);
        enemy.ReportHealth();
        character.ReportHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
