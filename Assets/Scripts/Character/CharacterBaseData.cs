using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterBaseData", menuName = "DataObjects/CharacterBaseData", order = 1)]
public class CharacterBaseData : ScriptableObject
{
    public string characterName;
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
