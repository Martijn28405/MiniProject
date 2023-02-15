using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Monster
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NamePlural { get; set; }
    public int MaximumDamage { get; set; }
    public int RewardExperience { get; set; }
    public int RewardGold { get; set; }
    public CountedItemList Loot { get; set; }
    public int MaximumHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }

    public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperience, int rewardGold, int maximumHitPoints, int currentHitPoints)
    {
        this.ID = id;
        this.Name = name;
        this.NamePlural = namePlural;
        this.MaximumDamage = maximumDamage;
        this.RewardExperience = rewardExperience;
        this.RewardGold = rewardGold;
        this.Loot = new CountedItemList();
        this.MaximumHitPoints = MaximumHitPoints;
        this.CurrentHitPoints = currentHistPoints;
    }

    public void TakeDamage(int damage)
    {
        CurrentHitPoints -= damage;
    }

    public void DealDamage(Player target)
    {
        target.TakeDamage(World.RandomGenerator.Next(0, MaximumDamage));
    }
}
