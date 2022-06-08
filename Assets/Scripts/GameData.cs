using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "DataObjects/GameData", order = 0)]
public class GameData : ScriptableObject
{
    public int barStatBaseValue;
    public int battleStatBaseValue;
    public float barStatDivider;
    public float battleStatDivider;
    public float levelBarStatDivider;
    public float levelBattleStatDivider;
}
