using UnityEngine;

public class BattleStuff
{
    public bool CheckSpeed(int playerSpeed, int enemySpeed)
    {
        bool isPlayerTurn = false;
        if (playerSpeed >= enemySpeed) isPlayerTurn = true;
        return isPlayerTurn;
    }
    public bool CheckForMiss(int missChance)
    {
        if (Random.Range(1, 100) < missChance) return true;
        return false;
    }
    public void CalculateDamage(GameData gameData, CharacterCurrentData attacker, CharacterCurrentData defender)
    {
        float pureDamage = attacker.currentAttack * gameData.attackMult + attacker.currentWeaponDamage * gameData.weaponMult;
        float pureDefense = defender.currentDefense * gameData.defenseMult + defender.currentArmorDefense * gameData.armorMult;
        float damage = Mathf.Round(Mathf.Sqrt(pureDamage - pureDefense) / gameData.damageDivider);
        if (damage < 1) damage = 1;
        Debug.Log(attacker.characterName + " will deal " + damage + " damage to " + defender.characterName);
    }

    /*<< widget "calculateDamage" >>
    << set $puredamage = $atk* 15 + $wpn* 7.5 >>
    << set $puredefense = $def* 10 + $arm* 5 >>
    << set $dmg = Math.round(Math.sqrt($puredamage - $puredefense) / 1.5) >>
    <<if $dmg< 1 >>
    << set $dmg = 1 >>
    <</if>><</ widget >><< widget "fightVictory" >>
    << set $spoils = $enemy.level* 10 + (random($enemy.level* -2,$enemy.level* 2)) >>
    << set $player.coins = $player.coins + $spoils >>
    << set $expgain = $enemy.level* 50 + (random($enemy.level* -20,$enemy.level* 20)) >>
    << set $player.experience = $player.experience + $expgain >>
    <</ widget >>*/
}
