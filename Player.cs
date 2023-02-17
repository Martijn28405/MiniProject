using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject
{
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
        public QuestList QuestLog { get; set; }
        public CountedItemList Inventory { get; set; }

        public Player(string name)
        {
            this.Name = name;
            this.QuestLog = new QuestList();
            this.Inventory = new CountedItemList();
            this.Gold = 0;
            this.MaximumHitPoints = 10;
            this.CurrentHitPoints = 10;
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
}