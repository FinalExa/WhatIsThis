using UnityEngine;

public class ShopInventory : MonoBehaviour
{
    /*<<set $villageShopInventory to[
    {
        name: "Old sword",
        quality: 1,
        quantity: 1,
        type: "weapon",
        value: 5,
        price: 30
    },
    {
name: "Old armor",
        quality: 1,
        quantity: 1,
        type: "armor",
        value: 5,
        price: 50
    },
    {
name: "Healing potion",
        quality: 1,
        quantity: -1,
        type: "healing",
        value: 10,
        price: 10
    }

<<widget "shop">>
    <<set $length = $inventoryShop.length>>
    <<if $shopIndex< 0>><<set $shopIndex = $length - 1>><</if>>
    <<if $shopIndex > $length - 1>><<set $shopIndex = 0>><</if>>
    <<if $player.coins >= $inventoryShop[$shopIndex].price>>
        <<if $inventoryShop[$shopIndex].quantity >= 1>>
            $inventoryShop[$shopIndex].name(x$inventoryShop[$shopIndex].quantity) - <<link[[Buy |$nameShop]]>>
                <<set $inventoryShop[$shopIndex].quantity = $inventoryShop[$shopIndex].quantity - 1>>
                <<set $player.coins = $player.coins - $inventoryShop[$shopIndex].price>>
                <<set $checkerFlag = 0>>
                <<for $checker = 0; ($checker< $inventory.length) && ($checkerFlag == 0); $checker++>>
                    <<if $inventoryShop[$shopIndex].name == $inventory[$checker].name>>
                        <<set $checkerFlag = 1>>
                        <<set $inventory[$checker].quantity++>>
                    <</if>>
                <</for>>
                <<if $checkerFlag == 0>>
                    <<set $invTempAdd to
    {
        name: $inventoryShop [$shopIndex].name,
                        quality: $inventoryShop [$shopIndex].quality,
                        quantity: 1,
                        type: $inventoryShop [$shopIndex].type,
                        value: $inventoryShop [$shopIndex].value
    }>>
                    <<set $inventory.push($invTempAdd)>>
                <</if>>
            <</link>> - $inventoryShop[$shopIndex].price coins
        <<elseif $inventoryShop[$shopIndex].quantity == -1>>
            $inventoryShop[$shopIndex].name - <<link[[Buy |$nameShop]]>>
                <<set $player.coins = $player.coins - $inventoryShop[$shopIndex].price>>
                <<set $checkerFlag = 0>>
                <<for $checker = 0; ($checker< $inventory.length) && ($checkerFlag == 0); $checker++>>
                    <<if $inventoryShop[$shopIndex].name == $inventory[$checker].name>>
                        <<set $checkerFlag = 1>>
                        <<set $inventory[$checker].quantity++>>
                    <</if>>
                <</for>>
                <<if $checkerFlag == 0>>
                    <<set $invTempAdd to
    {
        name: $inventoryShop [$shopIndex].name,
                        quality: $inventoryShop [$shopIndex].quality,
                        quantity: 1,
                        type: $inventoryShop [$shopIndex].type,
                        value: $inventoryShop [$shopIndex].value
    }>>
                    <<set $inventory.push($invTempAdd)>>
                <</if>>
            <</link>> - $inventoryShop[$shopIndex].price coins
        <<elseif $inventoryShop[$shopIndex].quantity == 0>>
            $inventoryShop[$shopIndex].name - The shop is out of stock of this item
        <</if>>
    <<else>>
        $inventoryShop[$shopIndex].name - You can't afford that ($inventoryShop[$shopIndex].price coins)
    <</if>><br>
    <<link[[Next Element |$nameShop]]>><<set $shopIndex = $shopIndex + 1 >><</ link >>< br >
    << link[[Previous Element |$nameShop]]>><< set $shopIndex = $shopIndex - 1 >><</ link >>
  <</ widget >>
]>> */
}
