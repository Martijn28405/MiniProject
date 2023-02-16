namespace Mini_Project;

public class Program
{
    public static void Main()
    {
        Player.CurrentWeapon = World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD);
        Player.CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME);
        Intro();
    }

    public static void Intro()
    {
        Console.WriteLine(
            "The people in your town are being terrorized by giant spiders. You Decide to do what you can to help");
    }
}
    