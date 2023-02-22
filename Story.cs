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
            Console.WriteLine(
                "The people in your town are being terrorized by giant spiders. You Decide to do what you can to help");
        }

        public void Menu()
        {

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. see game stats");
                Console.WriteLine("2. Fight");
                Console.WriteLine("3. Move");
                Console.WriteLine("4. Quit");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine($"Hello {player.Name} these are your stats:");
                        Console.WriteLine($"Maximum HP: {player.MaximumHitPoints}");
                        Console.WriteLine($"Current HP: {player.CurrentHitPoints}");
                        Console.WriteLine($"Gold: {player.Gold}");
                        Console.WriteLine($"Level: {player.Level}");
                        // Console.WriteLine($"Your Current location: {Map()}");
                        Console.WriteLine($"Inventory item count: {player.Inventory.TheCountedItemList.Count}");
                        Console.WriteLine($"Inventory items: \n {string.Join(",", player.Inventory)}");
                        Console.WriteLine();
                        break;
                    case "2":

                        if (player.CurrentLocation == World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN))
                        {
                            Alchemist quest1 = new Alchemist(player);
                            quest1.startQuest();
                        }
                        else if (player.CurrentLocation == World.LocationByID(World.LOCATION_ID_FARM_FIELD))
                        {
                            Farmer quest2 = new Farmer(player);
                            quest2.startQuest();
                        }
                        else
                        {
                            Console.WriteLine("No monster to fight here.");
                        }


                        // Temporary Alchemist test for the quest
                        // Console.WriteLine("Alchemist quest test");
                        // player.CurrentLocation = World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN);
                        // Alchemist alchemistGarden = new Alchemist(player);
                        // alchemistGarden.startQuest();
                        break;
                    case "3":
                        Console.WriteLine(player.CurrentLocation.Map());
                        Console.WriteLine(player.CurrentLocation.Compass());
                        Console.WriteLine("Where would you like to go?");
                        string direction = Console.ReadLine().ToUpper();
                        switch (direction)
                        {
                            case "N":
                            case "NORTH":
                                player.CurrentLocation = player.CurrentLocation.LocationToNorth;
                                Console.WriteLine($"You are at {player.CurrentLocation.Name} now");
                                Quests();
                                break;

                            case "E":
                            case "EAST":
                                player.CurrentLocation = player.CurrentLocation.LocationToEast;
                                Console.WriteLine($"You are at {player.CurrentLocation.Name} now");
                                Quests();
                                break;
                            case "S":
                            case "SOUTH":
                                player.CurrentLocation = player.CurrentLocation.LocationToSouth;
                                Console.WriteLine($"You are at {player.CurrentLocation.Name} now");
                                Quests();
                                break;
                            case "W":
                            case "WEST":
                                player.CurrentLocation = player.CurrentLocation.LocationToWest;
                                Console.WriteLine($"You are at {player.CurrentLocation.Name} now");
                                Quests();
                                break;
                            default:
                                Console.WriteLine("You can't go there, try again");
                                break;
                        }

                        break;
                    case "4":
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Wrong input, try something else.");
                        break;
                }
            }
        }

        private void Quests()
        {
            if (player.CurrentLocation == World.LocationByID(World.LOCATION_ID_ALCHEMIST_HUT))
            {
                Alchemist quest1 = new Alchemist(player);
                quest1.startQuest();

            }
            else if (player.CurrentLocation == World.LocationByID(World.LOCATION_ID_FARMHOUSE))
            {
                Farmer quest2 = new Farmer(player);
                quest2.startQuest();
            }
            else if (player.CurrentLocation == World.LocationByID(World.LOCATION_ID_SPIDER_FIELD))
            {
                SpiderQuest quest3 = new SpiderQuest(player);
                quest3.startQuest();
            }
            else
            {
                Menu();
            }
        }
    }
}