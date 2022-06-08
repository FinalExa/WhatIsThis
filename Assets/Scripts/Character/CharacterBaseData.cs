using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterBaseData", menuName = "DataObjects/CharacterBaseData", order = 1)]
public class CharacterBaseData : ScriptableObject
{
    public string characterName;
    [Range(1, 100)] public int level;
    [Range(10, 100)] public int baseHP;
    [Range(10, 100)] public int baseAttack;
    [Range(10, 100)] public int baseDefense;
    [Range(10, 100)] public int baseSpeed;
}
