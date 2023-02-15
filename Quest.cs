using System;


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
        public int itemID{get;set;}
        public int itemAmount{get;set;}


        public CountedItem(int itemID, int itemAmount)
        {
            this.itemID = itemID;
            this.itemAmount = itemAmount;

        }
    }
