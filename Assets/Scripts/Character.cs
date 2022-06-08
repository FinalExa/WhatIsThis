using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    int initialize = 1;
    private struct PlayerStory
    {
        public string origin;
        public string family;
        public string education;
        public string military;
        public string work;
        public string reason;
    }
    [System.Serializable]
    public struct BaseData
    {
        public string name;
        [Range(1, 100)] public int level;
        [Range(10, 100)] public int baseHP;
        [Range(0, 100)] public int baseMP;
        [Range(10, 100)] public int baseStamina;
        [Range(10, 100)] public int baseStrenght;
        [Range(10, 100)] public int baseResistance;
        [Range(10, 100)] public int baseSpeed;
        [Range(10, 100)] public int baseIntelligence;
        [Range(10, 100)] public int baseSwiftness;
        [Range(0, 100)] public int baseMagic;
    }
    [System.Serializable]
    public struct CurrentData
    {
        public float maxHP;
        public float currentHP;
        public float maxMP;
        public float currentMP;
        public float maxStamina;
        public float currentStamina;
        public float currentStrenght;
        public float currentResistance;
        public float currentSpeed;
        public float currentIntelligence;
        public float currentSwiftness;
        public float currentMagic;
        public float weaponDamage;
        public float armor;
        public float missChance;
        public float coins;
        public float experience;
        public float experienceCap;
    }
    public BaseData thisBaseData;
    public CurrentData thisCurrentData;
    public int barStatBaseValue;
    public int battleStatBaseValue;
    public float barStatDivider;
    public float battleStatDivider;
    public float levelDivider;

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
        for (int i = 1; i < thisBaseData.level; i++) LevelUpCharacter(i + 1);
        SetBarValues();
    }
    private float LevelUpStat(float baseStat, float baseValue, int level, float divider)
    {
        float stat;
        float fixedIncrement = (float)Math.Round(baseStat / divider, 4);
        float levelIncrement = (float)Math.Round((level * fixedIncrement) / levelDivider, 4);
        stat = baseValue + fixedIncrement + levelIncrement;
        return stat;
    }
    private void LevelOneCharacter()
    {
        thisCurrentData.maxHP = LevelUpStat(thisBaseData.baseHP, barStatBaseValue, 1, barStatDivider);
        thisCurrentData.maxStamina = LevelUpStat(thisBaseData.baseStamina, barStatBaseValue, 1, barStatDivider);
        thisCurrentData.currentStrenght = LevelUpStat(thisBaseData.baseStrenght, battleStatBaseValue, 1, battleStatDivider);
        thisCurrentData.currentResistance = LevelUpStat(thisBaseData.baseResistance, battleStatBaseValue, 1, battleStatDivider);
        thisCurrentData.currentSpeed = LevelUpStat(thisBaseData.baseSpeed, battleStatBaseValue, 1, battleStatDivider);
        thisCurrentData.currentIntelligence = LevelUpStat(thisBaseData.baseIntelligence, battleStatBaseValue, 1, battleStatDivider);
        thisCurrentData.currentSwiftness = LevelUpStat(thisBaseData.baseSwiftness, battleStatBaseValue, 1, battleStatDivider);
        if (thisCurrentData.maxMP != 0)
        {
            thisCurrentData.maxMP = LevelUpStat(thisBaseData.baseMP, barStatBaseValue, 1, barStatDivider);
            thisCurrentData.currentMagic = LevelUpStat(thisBaseData.baseMagic, battleStatBaseValue, 1, battleStatDivider);
        }
    }
    private void LevelUpCharacter(int curLevel)
    {
        thisCurrentData.maxHP = LevelUpStat(thisBaseData.baseHP, thisCurrentData.maxHP, curLevel, barStatDivider);
        thisCurrentData.maxStamina = LevelUpStat(thisBaseData.baseStamina, thisCurrentData.maxStamina, curLevel, barStatDivider);
        thisCurrentData.currentStrenght = LevelUpStat(thisBaseData.baseStrenght, thisCurrentData.currentStrenght, curLevel, battleStatDivider);
        thisCurrentData.currentResistance = LevelUpStat(thisBaseData.baseResistance, thisCurrentData.currentResistance, curLevel, battleStatDivider);
        thisCurrentData.currentSpeed = LevelUpStat(thisBaseData.baseSpeed, thisCurrentData.currentSpeed, curLevel, battleStatDivider);
        thisCurrentData.currentIntelligence = LevelUpStat(thisBaseData.baseIntelligence, thisCurrentData.currentIntelligence, curLevel, battleStatDivider);
        thisCurrentData.currentSwiftness = LevelUpStat(thisBaseData.baseSwiftness, thisCurrentData.currentSwiftness, curLevel, battleStatDivider);
        if (thisCurrentData.maxMP != 0)
        {
            thisCurrentData.maxMP = LevelUpStat(thisBaseData.baseMP, thisCurrentData.maxMP, curLevel, barStatDivider);
            thisCurrentData.currentMagic = LevelUpStat(thisBaseData.baseMagic, thisCurrentData.currentMagic, curLevel, battleStatDivider);
        }
    }
    private void SetBarValues()
    {
        thisCurrentData.currentHP = thisCurrentData.maxHP;
        thisCurrentData.currentStamina = thisCurrentData.maxStamina;
        thisCurrentData.currentMP = thisCurrentData.maxMP;
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
