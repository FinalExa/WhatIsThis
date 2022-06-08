using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameData gameData;
    public CharacterBaseData characterBaseData;
    public CharacterCurrentData characterCurrentData;


    private void Start()
    {
        GenerateCharacter();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) GenerateCharacter();
    }
    public void GenerateCharacter()
    {
        LevelOneCharacter();
        for (int i = 1; i < characterBaseData.level; i++) LevelUpCharacter(i + 1);
        SetBarValues();
    }
    private float LevelUpStat(float baseStat, float baseValue, int level, bool isBar)
    {
        float stat;
        float divider;
        float levelDivider;
        if (isBar)
        {
            divider = gameData.barStatDivider;
            levelDivider = gameData.levelBarStatDivider;
        }
        else
        {
            divider = gameData.battleStatDivider;
            levelDivider = gameData.levelBattleStatDivider;
        }
        float fixedIncrement = (float)Math.Round(baseStat / divider, 4);
        float levelIncrement = (float)Math.Round((level * fixedIncrement) / levelDivider, 4);
        stat = baseValue + fixedIncrement + levelIncrement;
        return stat;
    }
    private void LevelOneCharacter()
    {
        characterCurrentData.maxHP = LevelUpStat(characterBaseData.baseHP, gameData.barStatBaseValue, 1, true);
        characterCurrentData.maxStamina = LevelUpStat(characterBaseData.baseStamina, gameData.barStatBaseValue, 1, true);
        characterCurrentData.currentStrenght = LevelUpStat(characterBaseData.baseStrenght, gameData.battleStatBaseValue, 1, false);
        characterCurrentData.currentResistance = LevelUpStat(characterBaseData.baseResistance, gameData.battleStatBaseValue, 1, false);
        characterCurrentData.currentSpeed = LevelUpStat(characterBaseData.baseSpeed, gameData.battleStatBaseValue, 1, false);
        characterCurrentData.currentIntelligence = LevelUpStat(characterBaseData.baseIntelligence, gameData.battleStatBaseValue, 1, false);
        characterCurrentData.currentSwiftness = LevelUpStat(characterBaseData.baseSwiftness, gameData.battleStatBaseValue, 1, false);
        if (characterCurrentData.maxMP != 0)
        {
            characterCurrentData.maxMP = LevelUpStat(characterBaseData.baseMP, gameData.barStatBaseValue, 1, true);
            characterCurrentData.currentMagic = LevelUpStat(characterBaseData.baseMagic, gameData.battleStatBaseValue, 1, false);
        }
    }
    private void LevelUpCharacter(int curLevel)
    {
        characterCurrentData.maxHP = LevelUpStat(characterBaseData.baseHP, characterCurrentData.maxHP, curLevel, true);
        characterCurrentData.maxStamina = LevelUpStat(characterBaseData.baseStamina, characterCurrentData.maxStamina, curLevel, true);
        characterCurrentData.currentStrenght = LevelUpStat(characterBaseData.baseStrenght, characterCurrentData.currentStrenght, curLevel, false);
        characterCurrentData.currentResistance = LevelUpStat(characterBaseData.baseResistance, characterCurrentData.currentResistance, curLevel, false);
        characterCurrentData.currentSpeed = LevelUpStat(characterBaseData.baseSpeed, characterCurrentData.currentSpeed, curLevel, false);
        characterCurrentData.currentIntelligence = LevelUpStat(characterBaseData.baseIntelligence, characterCurrentData.currentIntelligence, curLevel, false);
        characterCurrentData.currentSwiftness = LevelUpStat(characterBaseData.baseSwiftness, characterCurrentData.currentSwiftness, curLevel, false);
        if (characterCurrentData.maxMP != 0)
        {
            characterCurrentData.maxMP = LevelUpStat(characterBaseData.baseMP, characterCurrentData.maxMP, curLevel, true);
            characterCurrentData.currentMagic = LevelUpStat(characterBaseData.baseMagic, gameData.battleStatBaseValue, curLevel, false);
        }
    }
    private void SetBarValues()
    {
        characterCurrentData.currentHP = characterCurrentData.maxHP;
        characterCurrentData.currentStamina = characterCurrentData.maxStamina;
        characterCurrentData.currentMP = characterCurrentData.maxMP;
    }

    /*public void PlayerLevelCheck(BaseData player)
    {
        player.experienceCap = Mathf.RoundToInt(player.level * 100 + (Mathf.Sqrt((player.level * player.level) - player.level) * player.level * 10));
        if (player.experience >= player.experienceCap)
        {
            player.experience -= player.experienceCap;
            player.level++;
            player = LevelUpCharacter(player, player.level);
        }
    }*/

    /*public void GenerateEnemy(CharacterData[] zoneEnemySpawn)
    {
        int enemyId = Random.Range(0, zoneEnemySpawn.Length - 1);
        CharacterData enemy;
        enemy = zoneEnemySpawn[enemyId];
        for (int enemyCreationIndex = 1; enemyCreationIndex <= enemy.level; enemyCreationIndex++)
        {
            if (enemyCreationIndex == 1)
            {
                enemy = GenerateLevelOneCharacter(enemy);
            }
            else
            {
                enemy = LevelUpCharacter(enemy, enemyCreationIndex);
            }
        }
        enemy.currentHP = enemy.maxHP;
        enemy.currentStamina = enemy.maxStamina;
        if (enemy.baseMP != 0) enemy.currentMP = enemy.maxMP;
    }*/
}
