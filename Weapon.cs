namespace Mini_Project;

public class Weapon
{
    public int ID;
    public string Name;
    public string NamePlural;
    public int MaximumDamage;
    public int MinimumDamage;

    public Weapon(int id, string name, string namePlural, int minimumDamage, int maximumDamage)
    {
        id = ID;
        name = Name;
        namePlural = NamePlural;
        maximumDamage = MaximumDamage;
        minimumDamage = MinimumDamage;
    }
}