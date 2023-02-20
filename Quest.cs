namespace Mini_Project
{
    public class Execute
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public string RewardItem { get; set; }
        public string RewardWeapon { get; set; }
        public List<CountedItem> QuestCompletionItems { get; set; }

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, string rewardItem, string rewardWeapon)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            RewardWeapon = rewardWeapon;
            QuestCompletionItems = new List<CountedItem>();
        }
    }



}

public class CountedItem
{
    public int itemID { get; set; }
    public int itemAmount { get; set; }


    public CountedItem(int itemID, int itemAmount)
    {
        this.itemID = itemID;
        this.itemAmount = itemAmount;

    }
}

public class Farmer
{
    // Console.WriteLine("I can't w'rk mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?");
    // method maken "clear the farmer's fields"
    // quest given by Farmer (F) vgm niet printen?
    // kill snakes in the farmer's field (v) v invoeren?
    // return to the Farmer with the 3 Snake fangs
    // remove from inventory
    // reward Adventurer's Pass
    // allows entry to the bridge
}

public class Alchemist
{
    public Alchemist

    // Console.Writeline("Those rats art nibbling on mine own h'rbs! I couldst very much useth an adventur'r to taketh careth of those folk …");
    // Given by Alchemist (A)
    // Return to the Alchemist with 3 Rat tails
    // Removed from inventory
    // Reward: a Club
}

public class GuardPost
{
    public int adventuresPass { get; set; }
    public string currentLocation { get; set; }

    public GuardPost(int adventuresPass, string currentLocation)
    {
        this.adventuresPass = adventuresPass;
        this.currentLocation = currentLocation;
    }
    public static void startQuest(string currentLocation, int adventuresPass)
    {
        if (currentLocation == "Guard's post")
        {
            Console.WriteLine("After going west you arrive at the Guard's post.\n Guard: Hello fellow! If you want to pass through here I will have to see your adventure's pass.");
            if (adventuresPass == 0)
            {
                Console.WriteLine("Guard:Turn back at once, peasant! Unless thee hast proof of thy grit.");
                Console.WriteLine("You need the Adventurer’s Pass to proceed to the bridge so you walk back to Town Square.");
            }
            //Switch location to Town Square
            else if (adventuresPass == 1)
            {
                Console.WriteLine("Guard: Ahh I see you are quite a strong fella. Just the right peerson for this job.");
                Console.WriteLine("Guard: Listen here adventurer. past this post there is a bridge. After crossing this bridge there will be a forest.");
                Console.WriteLine("Guard: The problem is. There are giant spiders in the forest that are forming a big threat for us.");
                Console.WriteLine("Guard: Could you please deal with these spiders for us? there will be an amazing reward for you if you manage to complete this quest.");
                Console.WriteLine("Choose:\n1. Proceed to  bridge\n 2. Turn back to Town Square");
                int choice = Int32.Parse(Console.ReadLine());
                while (choice != 1 || choice != 2)
                {
                    Console.WriteLine("Please Choose a valid option.");
                    Console.WriteLine("Choose:\n1. Proceed to  bridge\n 2. Turn back to Town Square");
                }
                if (choice == 1)
                {
                    System.Console.WriteLine("Guard: Thank you so much adventurer! Your heroic deed will be remembered by us.");
                    //Switch location to Bridge
                }
                else if (choice == 2)
                {
                    System.Console.WriteLine("Guard: I would really appreciate it if you came back soon. otherwise many lifes will be lost!");
                    //Switch location to Town Square
                }
            }
        }
    }


}
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
            while (choice != 1 || choice != 2)
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
