using System;
using System.Collections.Generic;
using System.Linq;
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
            Battle firstBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            firstBattle.StartBattle();
            Battle secondBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            secondBattle.StartBattle();
            Battle thirdBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            thirdBattle.StartBattle();
            Console.WriteLine("You won againt the rats, now return the the Alchemist with the 3 Rat tails");

            Console.WriteLine("Alchemist: Thankth for sav'ing my h'rbs");
            Player.CurrentWeapon = World.WeaponByID(World.WEAPON_ID_CLUB);
            Console.WriteLine("You have been rewarded with a Club");

            // Return to the Alchemist with 3 Rat tails
            // Removed from inventory

        }
    }
}