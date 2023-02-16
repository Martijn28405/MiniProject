namespace Mini_Project
{

    public class Monster
    {
        public int ID { get; set; }
        public string Name;
        public string NamePlural;
        public int MaximumDamage;
        public int RewardExperience;
        public int RewardGold;
        public CountedItemList Loot;
        public int MaximumHitPoints;
        public int CurrentHitPoints;

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
            CurrentHitPoints -= damage;
        }

        public void DealDamage(Player target)
        {
            target.TakeDamage(World.RandomGenerator.Next(0, MaximumDamage));
        }
    }
}    