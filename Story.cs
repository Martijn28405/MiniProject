using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiniProject.Quests;

namespace MiniProject
{
    public class Story
    {
        public Player player { get; set; }

        // stats van de player
        public Story(string playerName)
        {
            player = new Player(playerName)
            {
                CurrentWeapon = World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD),
                CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME)
            };
        }

        public void Intro()
        {
            Console.WriteLine("The people in your town are being terrorized by giant spiders. You Decide to do what you can to help");
        }

        public void Menu()
        {
            Console.WriteLine("You are home now");

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. see game stats");
                Console.WriteLine("2. Fight");
                Console.WriteLine("3. Move");
                Console.WriteLine("4. Quit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine($"Hello {player.Name} these are your stats:");
                        Console.WriteLine($"Maximum HP: {player.MaximumHitPoints}");
                        Console.WriteLine($"Current HP: {player.CurrentHitPoints}");
                        Console.WriteLine($"Gold: {player.Gold}");
                        // Console.WriteLine($"Your Current location: {Map()}");
                        Console.WriteLine($"Inventory item count: {player.Inventory.TheCountedItemList.Count}");
                        Console.WriteLine($"Inventory items: {player.Inventory}");
                        Console.WriteLine();
                        break;
                    case "2":
                        // Temporary Alchemist test for the quest
                        Console.WriteLine("Alchemist quest test");
                        player.CurrentLocation = World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN);
                        Alchemist alchemistGarden = new Alchemist(player);
                        alchemistGarden.startQuest();
                        break;
                    case "3":
                        Console.WriteLine(Map());
                        break;
                    case "4":
                        System.Environment.Exit(1);
                        break;
                    default:
                        break;
                }
            }
        }

        public string Map()
        {
            string town = World.LocationByID(World.LOCATION_ID_TOWN_SQUARE).Letter;
            string garden = World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN).Letter;
            string farmhouse = World.LocationByID(World.LOCATION_ID_FARMHOUSE).Letter;
            string farmfield = World.LocationByID(World.LOCATION_ID_FARM_FIELD).Letter;
            string hut = World.LocationByID(World.LOCATION_ID_ALCHEMIST_HUT).Letter;
            string guard = World.LocationByID(World.LOCATION_ID_GUARD_POST).Letter;
            string spider = World.LocationByID(World.LOCATION_ID_SPIDER_FIELD).Letter;
            string home = World.LocationByID(World.LOCATION_ID_HOME).Letter;
            string bridge = World.LocationByID(World.LOCATION_ID_BRIDGE).Letter;
            string map = "\n" + String.Format("{0,5}", garden) + "\n" + String.Format("{0,5}", hut) + "\n" + " " + farmfield + farmhouse + town + guard + bridge + spider + "\n" + "    " + home + "\n";
            return $"Current Location: {home} \n Map \n {map}";


        }
    }
}