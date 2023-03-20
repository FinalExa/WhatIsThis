using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    private BattleStuff battleStuff;
    [SerializeField] private GameData gameData;
    [SerializeField] private Character player;
    [SerializeField] private Character enemy;

    private void Awake()
    {
        battleStuff = new BattleStuff();
    }

    private void Start()
    {
        battleStuff.CalculateDamage(gameData, player.characterCurrentData, enemy.characterCurrentData);
        battleStuff.CalculateDamage(gameData, enemy.characterCurrentData, player.characterCurrentData);
    }
}
