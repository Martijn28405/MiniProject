namespace MiniProject
{
    public class SpiderQuest
    {
        public int spiderSilk { get; set; }
        public string currentLocation { get; set; }
        public SpiderQuest(int spiderSilk, string currentLocation)
        {
            this.spiderSilk = spiderSilk;
            this.currentLocation = currentLocation;
        }

        public static void BridgeDialoge(string currentLocation, int spiderSilk)
        {
            if (currentLocation == "Bridge")
            {
                System.Console.WriteLine("After passing through the Guard's post you find yourself at the bridge.");
                System.Console.WriteLine("Quest unlocked!\nQuets description:\nThere are giant spiders in the forest that form a threat for the guards!\nKill 3 spiders for a reward.");
                System.Console.WriteLine("Do you accept the quest?\n1. Yes(Proceed to Forest)\n2. No(Go back to Town Square)");
                int choice = Int32.Parse(Console.ReadLine());
                while (choice != 1 && choice != 2)
                {
                    BridgeDialoge("Bridge", 0);
                }
                if (choice == 1)
                {
                    System.Console.WriteLine("You accepted the quest!\nGoodluck!");
                    currentLocation = "Forest";
                }
                else if (choice == 2)
                {
                    System.Console.WriteLine("You chose to chicken out of the quest!\nAre you really an adventurer?\nYou walk back to Town Square while the guard who let you through looks at you in disappointment.");
                    currentLocation = "Town Square";
                }
            }
            if (spiderSilk == 3)
            {
                //Dialoge + Receiving reward.
            }
        }

        public static void Forest(string currentLocation, int spiderSilk)
        {
            if (currentLocation == "Forest")
            {
                System.Console.WriteLine("You finally entered the forest.\nAfter walking for a while you find another adventurer running away from something.");
                System.Console.WriteLine("???: Run away right now!\n Otherwise you will be killed!\nThe adventurer runs past you.\nWhat will you do?");
                System.Console.WriteLine("1. Follow the path where the adventurer came from\n2. Follow another path.");
                int choice = Int32.Parse(Console.ReadLine());
                while (choice != 1 || choice != 2)
                {
                    Forest("Forest", 0);
                }
                if (choice == 1)
                {
                    System.Console.WriteLine("You chose to ignore the adventurers advice!\nYou almost immediately see an Giant Spider!\n He looks stronger than a normal Giant spider.");
                    System.Console.WriteLine("You: This Spider look way more powerful than other Giant Spiders. But the must also means I will get more Spidersilk!");
                    System.Console.WriteLine("You: So this is why The Guards were so scared!");
                    //Battle with spider
                    spiderSilk += 2;//When defeated
                }
                else if (choice == 2)
                {
                    System.Console.WriteLine("You chose to follow the adventurers advice!\nAfter walking for a while you feel a cold chill in your spine.");
                    System.Console.WriteLine("You look around to see nothing and sprint away in fear.\n");
                    System.Console.WriteLine("Suddenly a Giant Spider appears infront of you. It looks like its mutated.\nYou: This Spider looks way stronger than usual");
                    System.Console.WriteLine("You: I don't have any other choice then to fight it.\nYou: There is no way I can outrun a Giant Spider in a forest!");
                    System.Console.WriteLine("You: So this is why The Guards were so scared!");
                    //battle with spider
                    spiderSilk += 2;//When defeated
                }
            }
            else
            {
                BridgeDialoge("Bridge", 0);
            }
            if (spiderSilk == 2)
            {
                System.Console.WriteLine("You defeated the Giant Spider!\nYou obtained 2 Spider silk.\n");
                System.Console.WriteLine("After defeating the mutated Giant spider you wander around the forest, in search of another Giant Spider to slay.");
                System.Console.WriteLine("By chance you stumble upon a little nest with a baby spider.");
                System.Console.WriteLine("You: I bet that if I kill this baby spider I would have enough spider silk to. But it would be a little pathetic to kill a baby.");
                System.Console.WriteLine("Will you choose to kill the baby? or continue your search for one Giant Spider?");
                System.Console.WriteLine("1. Kill the baby\n2. Continue search");
                int choice2 = Int32.Parse(Console.ReadLine());
                while (choice2 != 1 || choice2 != 2)
                {
                    Forest("", 2);
                }
                if (choice2 == 1)
                {
                    System.Console.WriteLine("You chose to coldheartedly kill the baby spider.\nYou: I should show no mercy to monsters even if they are a baby!");
                    spiderSilk++;
                    System.Console.WriteLine("You: I finally have enough Spider silk for the reward!. I should go back to the Guard's post!");
                    BridgeDialoge("", 3);
                }
                else if (choice2 == 2)
                {
                    System.Console.WriteLine("You chose not to kill the baby spider!\nYou: Even if it's a monster I can't kill a baby. What type of demon would do that?");
                    System.Console.WriteLine("After walking away from the nest you find another Giant Spider!.");
                    System.Console.WriteLine("");
                }
            }
        }
    }
}