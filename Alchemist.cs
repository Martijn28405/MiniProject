using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MiniProject
{
    public class Alchemist
    {
        public Player Player { get; set; }
        public Alchemist(Player player)
        {
            this.Player = player;
        }
        public void startQuest()
        {
            Console.WriteLine("Alchemist: Those rats art nibbling on mine own h'rbs! I couldst very much useth an adventur'r to taketh careth of those folk …");
            Console.WriteLine("You decide to help the Alchemist and enter the garden filled with rats.");
            Player.CurrentLocation = World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN);

            Battle firstBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            firstBattle.StartBattle();
            Battle secondBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            secondBattle.StartBattle();
            Battle thirdBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            thirdBattle.StartBattle();
            Player.CurrentLocation = World.LocationByID(World.LOCATION_ID_TOWN_SQUARE);

            Console.WriteLine("You won against the rats, you return to the alchemist to give him the 3 Rat tails.");
            // Loop through the inventory to check if the needed items are in there and then remove those items.
            foreach (CountedItem item in Player.Inventory.TheCountedItemList)
            {
                if (item.TheItem.ID == World.ITEM_ID_RAT_TAIL && item.Quantity >= 3)
                {
                    Player.Inventory.TheCountedItemList.Remove(item);
                    break;
                }
            }
            Console.WriteLine("Alchemist: Thankth for sav'ing my h'rbs");
            Console.WriteLine("I will give you a reward in exchange for the rat tails");

            Player.CurrentWeapon = World.WeaponByID(World.WEAPON_ID_CLUB);
            Console.WriteLine("The Alchemist rewards you by giving you a new weapon: a Club");
            Console.WriteLine("You decide to immediately equip your newly received weapon.");
        }
    }
}