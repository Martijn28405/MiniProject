using System;


namespace Mini_Project
{ 
    public class Quest
    {
        public int ID;
        public string Name;
        public string Description;
        public int RewardExperiencePoints;
        public int RewardGold;
        public string RewardItem;
        public string RewardWeapon;
        public CountedItemList QuestCompletionItems;

        public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, string rewardItem, string rewardWeapon)
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
    }



}