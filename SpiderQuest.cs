namespace MiniProject
{
    public class SpiderQuest
    {
        public Player Player { get; set; }
        public SpiderQuest(Player player)
        {
            this.Player = player;
        }

        public void startQuest()
        {
            Console.WriteLine("You finally entered the forest.\nAfter walking for a while you find another adventurer running away from something.");
            Console.WriteLine("???: Run away right now!\n Otherwise you will be killed!\nThe adventurer runs past you.\nWhat will you do?");
            Console.WriteLine("1. Follow the path where the adventurer came from\n2. Follow another path.");
            string userChoice = Console.ReadLine();
            if (userChoice == "1")
            {
                System.Console.WriteLine("You chose to ignore the adventurers advice!\nYou almost immediately see a horde of giant spiders, they look stronger than usual.");
                System.Console.WriteLine("You decide to try fighting them.");
                battleBridge();

            }
            else if (userChoice == "2")
            {
                System.Console.WriteLine("You chose to follow the adventurers advice!\nAfter walking for a while you feel a cold chill in your spine.");
                System.Console.WriteLine("You look around to see nothing and sprint away in fear.\n");
                System.Console.WriteLine("Suddenly a horde of giant spiders appear infront of you. They look stronger than usual.");
                System.Console.WriteLine("You don't have any other choice then to fight.");
                battleBridge();

            }
        }
        public void battleBridge()
        {
            Battle firstBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            firstBattle.StartBattle();
            Battle secondBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            secondBattle.StartBattle();
            Battle thirdBattle = new Battle(Player, Player.CurrentLocation.MonsterLivingHere);
            thirdBattle.StartBattle();
            Console.WriteLine("After killing the giant spiders, you decide to return to the Bridge.\n There you see one of the guards from earlier.");
            Console.WriteLine("He waves at you and asks how it went, you show him the spider silk and he lets out a sigh of relief.\nAfter thanking you he gives you the Winner's Medal.");
            Player.Inventory.AddItem(World.ItemByID(World.ITEM_ID_WINNERS_MEDAL));
            Console.WriteLine("After bringing peace to the village your quest finally ends. Good job!\n THE END!");
            Environment.Exit(1);
        }
    }
}
