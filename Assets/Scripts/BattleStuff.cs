using UnityEngine;

public class BattleStuff : MonoBehaviour
{
    public bool CheckSpeed(int playerSpeed, int enemySpeed)
    {
        bool isPlayerTurn = false;
        if (playerSpeed >= enemySpeed) isPlayerTurn = true;
        return isPlayerTurn;
    }
    /* <<widget "hitOrMiss">>
    <<if random(1, 100) <= $miss >>
        << set $miss = 0 >>


     <<else>>


         << set $miss = 1 >>


      <</if>>
  <</ widget >>

  << widget "calculateDamage" >>


       << set $puredamage = $atk* 15 + $wpn* 7.5 >>
 


           << set $puredefense = $def* 10 + $arm* 5 >>
  


               << set $dmg = Math.round(Math.sqrt($puredamage - $puredefense) / 1.5) >>
  


                <<if $dmg< 1 >>
  


                    << set $dmg = 1 >>
  


                 <</if>>
  
             <</ widget >>

             << widget "fightVictory" >>
  


                  << set $spoils = $enemy.level* 10 + (random($enemy.level* -2,$enemy.level* 2)) >>
  


                   << set $player.coins = $player.coins + $spoils >>
  


                    << set $expgain = $enemy.level* 50 + (random($enemy.level* -20,$enemy.level* 20)) >>
  
      << set $player.experience = $player.experience + $expgain >>
   <</ widget >>*/
}
