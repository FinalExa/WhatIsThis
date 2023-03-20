using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "Data/GameData", order = 0)]
public class GameData : ScriptableObject
{
    [Header("Character Multipliers")]
    public int barStatBaseValue;
    public int battleStatBaseValue;
    public float barStatDivider;
    public float battleStatDivider;
    public float levelBarStatDivider;
    public float levelBattleStatDivider;
    [Header("Battle Multipliers")]
    public float attackMult;
    public float weaponMult;
    public float defenseMult;
    public float armorMult;
    public float damageDivider;
}
