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
            Name = name;
            CurrentHitPoints = 10;
            MaximumHitPoints = 10;
            Gold = 0;
            ExperiencePoints = 0;
            Level = 1;
            Inventory = new CountedItemList();
        }

        public void TakeDamage(int damage)
        {
            // When taking damage the player loses HP based on the damage.
            CurrentHitPoints -= damage;
            Console.WriteLine($"You took {damage} damage, your current HP is {CurrentHitPoints}/{MaximumHitPoints}.");
        }

        public void DealDamage(Monster target)
        {
            int DiceRoll = World.RandomGenerator.Next(1, 20);
            // When the dice rolls 1 the player misses.
            if (DiceRoll == 1)
            {
                Console.WriteLine("You missed!");
            }
            // When the dice rolls 20 the player does critical damage (extra damage).
            else if (DiceRoll == 20)
            {
                int criticalHit = World.RandomGenerator.Next(CurrentWeapon.MinimumDamage, CurrentWeapon.MaximumDamage) + 1;
                target.TakeDamage(criticalHit);
                Console.WriteLine($"You made a critical hit of {criticalHit} damage!");
            }
            // When the dice rolls anything else the player does regular damage between their minimun and maximun damage.
            int damageAmount = World.RandomGenerator.Next(CurrentWeapon.MinimumDamage, CurrentWeapon.MaximumDamage);
            target.TakeDamage(damageAmount);
            Console.WriteLine($"You did {damageAmount} damage!");
        }

        public void Recover()
        {
            int healAmount = World.RandomGenerator.Next(0, MaximumHitPoints);
            int healedAmount = healAmount;
            // Checks if the healAmount is bigger than the Maximum HP.
            if (healAmount + CurrentHitPoints > MaximumHitPoints)
            {
                // If the amount is bigger it substracts the Current HP from the Maximum HP to only heal the difference and not go over the Maximum HP.
                healedAmount = MaximumHitPoints - CurrentHitPoints;
                CurrentHitPoints = MaximumHitPoints;
            }
            else
            {
                // Otherwise it just heals the rolled amount.
                CurrentHitPoints += healAmount;
            }
            Console.WriteLine($"You healed for {healedAmount}, your current HP is {CurrentHitPoints}");
        }
    }
}