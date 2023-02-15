namespace Mini_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Player
{
    public string Name { get; set; }
    public int CurrentHitPoints { get; set; }
    public int MaximumHitPoints { get; set; }
    public int Gold { get; set; }
    public int ExperiencePoints { get; set; }
    public int Level { get; set; }
    public Weapon CurrentWeapon { get; set; }
    public Location CurrentLocation { get; set; }
    public QuestLog QuestList { get; set; }
    public CountedItemList Inventory { get; set; }

    public Player(string name, int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level)
    {
        this.Name = name;
        this.CurrentHitPoints = currentHitPoints;
        this.MaximumHitPoints = maximumHitPoints;
        this.Gold = gold;
        this.ExperiencePoints = experiencePoints;
        this.Level = level;
        // this.QuestList = new QuestLog();
        // this.Inventory = new Inventory();
    }

    public void TakeDamage(int damage)
    {
        CurrentHitPoints -= damage;
    }

    // public void DealDamage(Monster target)
    // {
    //     target.TakeDamage(World.RandomGenerator.Next(CurrentWeapon.MinimumDamage, CurrentWeapon.MaximumDamage));
    // }
}