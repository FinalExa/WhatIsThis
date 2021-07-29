using UnityEngine;

public class ImportScript : MonoBehaviour
{
    int initialize = 1;
    private struct Time
    {
        public int days;
        public int hours;
        public int minutes;
    }
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
    public struct Character
    {
        public string name;
        public int level;
        public int baseHP;
        public int maxHP;
        public int currentHP;
        public int baseMP;
        public int maxMP;
        public int currentMP;
        public int baseStamina;
        public int maxStamina;
        public int currentStamina;
        public int baseStrenght;
        public int currentStrenght;
        public int baseResistance;
        public int currentResistance;
        public int baseSpeed;
        public int currentSpeed;
        public int baseIntelligence;
        public int currentIntelligence;
        public int baseSwiftness;
        public int currentSwiftness;
        public int baseMagic;
        public int currentMagic;
        public int weaponDamage;
        public int armor;
        public int coins;
        public int missChance;
        public int experience;
        public int experienceCap;
    }
    public Character playerCharacter;
    public void GenerateEnemy(Character[] zoneEnemySpawn)
    {
        int enemyId = Random.Range(0, zoneEnemySpawn.Length - 1);
        Character enemy;
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
    }
    public Character GenerateLevelOneCharacter(Character character)
    {
        character.maxHP = Mathf.RoundToInt(10 + (character.baseHP / 10));
        character.maxStamina = Mathf.RoundToInt(10 + (character.baseStamina / 10));
        if (character.baseMP != 0) character.maxMP = Mathf.RoundToInt(10 + (character.baseMP / 10));
        character.currentStrenght = Mathf.RoundToInt(5 + (character.baseStrenght / 10));
        character.currentResistance = Mathf.RoundToInt(5 + (character.baseResistance / 10));
        character.currentSpeed = Mathf.RoundToInt(5 + (character.baseSpeed / 10));
        character.currentIntelligence = Mathf.RoundToInt(5 + (character.baseIntelligence / 10));
        character.currentSwiftness = Mathf.RoundToInt(5 + (character.baseSwiftness / 10));
        character.currentMagic = Mathf.RoundToInt(5 + (character.baseMagic / 10));
        return character;
    }

    public Character LevelUpCharacter(Character character, int level)
    {
        character.maxHP = Mathf.RoundToInt(character.maxHP + ((character.baseHP / 10) * level));
        character.maxStamina = Mathf.RoundToInt(character.maxStamina + ((character.baseStamina / 10) * level));
        if (character.baseMP != 0) character.maxMP = Mathf.RoundToInt(character.maxMP + ((character.baseMP / 10) * level));
        character.currentStrenght = Mathf.RoundToInt(character.currentStrenght + ((character.baseStrenght / 10) * level));
        character.currentResistance = Mathf.RoundToInt(character.currentResistance + ((character.baseResistance / 10) * level));
        character.currentSpeed = Mathf.RoundToInt(character.currentSpeed + ((character.baseSpeed / 10) * level));
        character.currentIntelligence = Mathf.RoundToInt(character.currentIntelligence + ((character.baseIntelligence / 10) * level));
        character.currentSwiftness = Mathf.RoundToInt(character.currentSwiftness + ((character.baseSwiftness / 10) * level));
        character.currentMagic = Mathf.RoundToInt(character.currentMagic + ((character.baseMagic / 10) * level));
        return character;
    }

    public void PlayerLevelCheck(Character player)
    {
        player.experienceCap = Mathf.RoundToInt(player.level * 100 + (Mathf.Sqrt((player.level * player.level) - player.level) * player.level * 10));
        if (player.experience >= player.experienceCap)
        {
            player.experience -= player.experienceCap;
            player.level++;
            player = LevelUpCharacter(player, player.level);
        }
    }

    /*<<widget "zoneMovement">>
        <<if ($zoneArray[$position] == "1") or($zoneArray[$position] == "3") or($zoneArray[$position] == "7") or($zoneArray[$position] == "8") or($zoneArray[$position] == "11") or($zoneArray[$position] == "12") or($zoneArray[$position] == "14") or($zoneArray[$position] == "15")>>
            <<link[[Go ←|$zoneName]]>><<set $position = $position - 1>><<set $time.minutes = $time.minutes + 2>><</link>> - 0:02<br>
        <</if>>
        <<if ($zoneArray[$position] == "1") or($zoneArray[$position] == "4") or($zoneArray[$position] == "9") or($zoneArray[$position] == "10") or($zoneArray[$position] == "12") or($zoneArray[$position] == "13") or($zoneArray[$position] == "14") or($zoneArray[$position] == "15")>>
            <<link[[Go →|$zoneName]]>><<set $position = $position + 1>><<set $time.minutes = $time.minutes + 2>><</link>> - 0:02<br>
        <</if>>
        <<if ($zoneArray[$position] == "2") or($zoneArray[$position] == "5") or($zoneArray[$position] == "7") or($zoneArray[$position] == "9") or($zoneArray[$position] == "11") or($zoneArray[$position] == "12") or($zoneArray[$position] == "13") or($zoneArray[$position] == "15")>>
            <<link[[Go ↑|$zoneName]]>><<set $position = $position - $zoneRowLength>><<set $time.minutes = $time.minutes + 2>><</link>> - 0:02<br>
        <</if>>
        <<if ($zoneArray[$position] == "2") or($zoneArray[$position] == "6") or($zoneArray[$position] == "8") or($zoneArray[$position] == "10") or($zoneArray[$position] == "11") or($zoneArray[$position] == "13") or($zoneArray[$position] == "14") or($zoneArray[$position] == "15")>>
            <<link[[Go ↓|$zoneName]]>><<set $position = $position + $zoneRowLength>><<set $time.minutes = $time.minutes + 2>><</link>> - 0:02<br>
        <</if>>
    <</widget>>



    <<widget "timeCheck">>
    <<if $time.minutes >= 60>>
        <<set $time.minutes = $time.minutes - 60 >>
        <<set $time.hours = $time.hours + 1>>
    <</if>>
    <<if $time.hours >= 24>>
        <<set $time.hours = $time.hours - 24 >>
        <<set $time.days = $time.days + 1>>
    <</if>>
    <</widget>>*/
}
