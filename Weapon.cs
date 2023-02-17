namespace MiniProject
{
    public class Weapon
    {
        public int ID;
        public string Name;
        public string NamePlural;
        public int MinimumDamage;
        public int MaximumDamage;

        public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePlural;
            this.MinimumDamage = minimumDamage;
            this.MaximumDamage = maximumDamage;

        }
    }
}