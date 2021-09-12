using UnityEngine;

public class Zones : MonoBehaviour
{
    private struct Time
    {
        public int days;
        public int hours;
        public int minutes;
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
