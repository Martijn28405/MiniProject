namespace Mini_Project;

public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public int RewardExperiencePoints;
    public int RewardGold;
    public Item Rewarditem;
    public Weapon RewardWeapon;
    public List<CountedItemList> QuestCompletionItems;

    public Quest(int id, string name, string description, int rewardExperiencePoints, int rewardGold, Item rewarditem,
        Weapon rewardWeapon)
    {
        id = ID;
        name = Name;
        description = Description;
        rewardExperiencePoints = RewardExperiencePoints;
        rewardGold = RewardGold;
        rewardWeapon = RewardWeapon;
        rewarditem = Rewarditem;
        
    }
    
    
}