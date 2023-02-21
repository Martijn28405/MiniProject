using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Quests
{

    public class Farmer
    {
        public Player Player { get; set; }
        public Farmer(Player player)
        {
            this.Player = player;
        }
        public void startQuest()
        {
            Console.WriteLine("Farmer: I can't w'rk mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?");
            Battle firstBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            firstBattle.StartBattle();
            Battle secondBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            secondBattle.StartBattle();
            Battle thirdBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            thirdBattle.StartBattle();
            Console.WriteLine("You won againt the snakes, now return to the the Farmer with 3 Snake fangs");

            // Player.Inventory.TheCountedItemList.Remove(World.ITEM_ID_SNAKESKIN);
            Console.WriteLine("You returned to the Farmer with the three snake fangs");

            Console.WriteLine("Farmer: Thankth for sav'ing my landeth");
            // Adventurers's pass moet nog worden toegevoegd
            Console.WriteLine("You have been rewarded with the Adventurer's Pass to enter the bridge");
        }
        // method maken "clear the farmer's fields"
        // quest given by Farmer (F) vgm niet printen?
        // kill snakes in the farmer's field (v) v invoeren?
        // return to the Farmer with the 3 Snake fangs
        // remove from inventory
        // reward Adventurer's Pass
        // allows entry to the bridge
    }
}