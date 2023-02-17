namespace MiniProject
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public Item RewardItem { get; set; }
        public Weapon RewardWeapon { get; set; }
        public CountedItemList QuestCompletionItems { get; set; }

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, Item rewardItem, Weapon rewardWeapon)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            RewardItem = rewardItem;
            RewardWeapon = rewardWeapon;
            QuestCompletionItems = new CountedItemList();
        }

        public void Farmer()
        {
            // Console.Writeline("I can't w'rk mine own landeth with those pesky snakes slith'ring 'round! Shall thee holp me?");
            // method maken "clear the farmer's fields"
            // quest given by Farmer (F) vgm niet printen?
            // kill snakes in the farmer's field (v) v invoeren?
            // return to the Farmer with the 3 Snake fangs
            // remove from inventory
            // reward Adventurer's Pass
            // allows entry to the bridge
        }

        public void Alchemist()
        {
            // Console.Writeline("Those rats art nibbling on mine own h'rbs! I couldst very much useth an adventur'r to taketh careth of those folk …");
            // Given by Alchemist (A)
            // Return to the Alchemist with 3 Rat tails
            // Removed from inventory
            // Reward: a Club
        }

        public void Guard()
        {
            // Console.Writeline("Turn back at once, peasant! Unless thee hast proof of thy grit.");
            // You need the Adventurer’s Pass to proceed to the bridge
        }

        public void SpiderSilk()
        {
            // Console.Writeline("I shalt releaseth the town folks of their feareth!");
            // Return to the bridge with 3 Spider silks
            // Removed from inventory
            // Reward: the Winner’s Medal
        }
    }
}