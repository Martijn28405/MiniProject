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
    public static Weapon CurrentWeapon { get; set; }
    public static Location CurrentLocation { get; set; }
    public QuestList QuestLog  { get; set; }
    public CountedItemList Inventory { get; set; }

    public Player(string name)
    {
        this.Name = name;
        this.QuestLog = new QuestList();
        this.Inventory = new CountedItemList();
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