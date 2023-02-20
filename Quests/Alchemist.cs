using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Quests
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
            Console.WriteLine("Do you want to help the Alchemist and Attack the rats? (yes/no)");
            string userChoice = Console.ReadLine();
            if (userChoice == "yes")
            {
                Battle firstBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
                firstBattle.StartBattle();
                Battle secondBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
                secondBattle.StartBattle();
            }
            // Given by Alchemist (A)
            // Return to the Alchemist with 3 Rat tails
            // Removed from inventory
            // Reward: a Club
        }
    }
}