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
        for (int i = 1; i < thisBaseData.level; i++) LevelUpCharacter();
        SetBarValues();
    }
    private float LevelUpStat(float baseStat, float baseValue, int level, float divider)
    {
        float stat;
        float fixedIncrement = baseStat / divider;
        float levelIncrement = level / levelDivider * fixedIncrement;
        stat = baseValue + fixedIncrement + levelIncrement;
        return stat;
    }
    private void LevelOneCharacter()
    {
        thisCurrentData.maxHP = LevelUpStat(thisBaseData.baseHP, barStatBaseValue, thisBaseData.level, barStatDivider);
        thisCurrentData.maxStamina = LevelUpStat(thisBaseData.baseStamina, barStatBaseValue, thisBaseData.level, barStatDivider);
        thisCurrentData.currentStrenght = LevelUpStat(thisBaseData.baseStrenght, battleStatBaseValue, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentResistance = LevelUpStat(thisBaseData.baseResistance, battleStatBaseValue, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentSpeed = LevelUpStat(thisBaseData.baseSpeed, battleStatBaseValue, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentIntelligence = LevelUpStat(thisBaseData.baseIntelligence, battleStatBaseValue, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentSwiftness = LevelUpStat(thisBaseData.baseSwiftness, battleStatBaseValue, thisBaseData.level, battleStatDivider);
        if (thisCurrentData.maxMP != 0)
        {
            thisCurrentData.maxMP = LevelUpStat(thisBaseData.baseMP, barStatBaseValue, thisBaseData.level, barStatDivider);
            thisCurrentData.currentMagic = LevelUpStat(thisBaseData.baseMagic, battleStatBaseValue, thisBaseData.level, battleStatDivider);
        }
    }
    private void LevelUpCharacter()
    {
        thisCurrentData.maxHP = LevelUpStat(thisBaseData.baseHP, thisCurrentData.maxHP, thisBaseData.level, barStatDivider);
        thisCurrentData.maxStamina = LevelUpStat(thisBaseData.baseStamina, thisCurrentData.maxStamina, thisBaseData.level, barStatDivider);
        thisCurrentData.currentStrenght = LevelUpStat(thisBaseData.baseStrenght, thisCurrentData.currentStrenght, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentResistance = LevelUpStat(thisBaseData.baseResistance, thisCurrentData.currentResistance, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentSpeed = LevelUpStat(thisBaseData.baseSpeed, thisCurrentData.currentSpeed, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentIntelligence = LevelUpStat(thisBaseData.baseIntelligence, thisCurrentData.currentIntelligence, thisBaseData.level, battleStatDivider);
        thisCurrentData.currentSwiftness = LevelUpStat(thisBaseData.baseSwiftness, thisCurrentData.currentSwiftness, thisBaseData.level, battleStatDivider);
        if (thisCurrentData.maxMP != 0)
        {
            thisCurrentData.maxMP = LevelUpStat(thisBaseData.baseMP, thisCurrentData.maxMP, thisBaseData.level, barStatDivider);
            thisCurrentData.currentMagic = LevelUpStat(thisBaseData.baseMagic, thisCurrentData.currentMagic, thisBaseData.level, battleStatDivider);
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
