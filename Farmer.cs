using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject
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
            Console.WriteLine("You decide to help the farmer and enter the field filled with snakes.");

            Battle firstBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            firstBattle.StartBattle();
            Battle secondBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            secondBattle.StartBattle();
            Battle thirdBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            thirdBattle.StartBattle();

            Console.WriteLine("You won againt the snakes, now return to the the Farmer with 3 Snake fangs");
            Console.WriteLine("You've returned to the Farmer with the three snake fangs.");

            Console.WriteLine("You give the fangs to the farmer to prove that you've slain the snakes.");
            // Loop through the inventory to check if the needed items are in there and then remove those items.
            foreach (CountedItem item in Player.Inventory.TheCountedItemList)
            {
                if (item.TheItem.ID == World.ITEM_ID_SNAKE_FANG && item.Quantity >= 3)
                {
                    Player.Inventory.TheCountedItemList.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Farmer: Thankth for sav'ing my landeth.");

            Console.WriteLine("You have been rewarded with the Adventurer's Pass to enter the bridge.");
            // reward Adventurer's Pass
            // allows entry to the bridge
        }
    }
}