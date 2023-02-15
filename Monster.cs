namespace Mini_Project;

public class Monster
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MaximumDamage;
    public int RewardExperience;
    public int RewardGold;
    public List<CountedItemList> Loot;
    public int CurrentHitPoints;
    
    

    public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperience, int rewardGold, List<CountedItemList> loot, int currentHitPoints)
    {
        id = ID;
        name = Name;
        namePlural = NamePlural;
        maximumDamage = MaximumDamage;
        rewardExperience = RewardExperience;
        rewardGold = RewardGold;
        loot = Loot;
        currentHitPoints = CurrentHitPoints;

    }
}