namespace MiniProject
{
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

        public Monster(int id, string name, string namePlural, int maximumDamage, int rewardExperience, int rewardGold,
            int maximumHitPoints, int currentHitPoints)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePlural;
            this.MaximumDamage = maximumDamage;
            this.RewardExperience = rewardExperience;
            this.RewardGold = rewardGold;
            this.Loot = new CountedItemList();
            this.MaximumHitPoints = MaximumHitPoints;
            this.CurrentHitPoints = currentHitPoints;
        }

        public void TakeDamage(int damage)
        {
            // When taking damage the monster loses HP based on the damage.
            CurrentHitPoints -= damage;
            Console.WriteLine($"The {Name} took {damage} damage, it's current HP is {CurrentHitPoints}/{MaximumHitPoints}.");
        }

        public void DealDamage(Player target)
        {
            int DiceRoll = World.RandomGenerator.Next(1, 20);
            // When the dice rolls 1 the monster misses.
            if (DiceRoll == 1)
            {
                Console.WriteLine($"The {Name} missed!");
            }
            // When the dice rolls 20 the monster does critical damage (extra damage).
            else if (DiceRoll == 20)
            {
                int criticalHit = World.RandomGenerator.Next(0, MaximumDamage) + 1;
                target.TakeDamage(criticalHit);
                Console.WriteLine($"The {Name} made a critical hit of {criticalHit} damage!");
            }
            // When the dice rolls anything else the monster does regular damage between their minimun and maximun damage.
            int damageAmount = World.RandomGenerator.Next(0, MaximumDamage);
            target.TakeDamage(damageAmount);
            Console.WriteLine($"The {Name} did {damageAmount} of damage!");
        }
    }
}