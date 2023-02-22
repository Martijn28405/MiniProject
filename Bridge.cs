namespace MiniProject;

public class Bridge
{
    public Player Player { get; set; }

    public Bridge(Player player)
    {
        this.Player = player;
    }

    public void startQuest()
    {
        Console.WriteLine("After passing through the Guard's post you find yourself at the bridge.");
        Console.WriteLine(
            "Quest unlocked!\nQuets description:\nThere are giant spiders in the forest that form a threat for the guards!\nKill 3 spiders for a reward.");
        Console.WriteLine("Do you accept the quest?(yes/no)");
        string choice = Console.ReadLine();
        if (choice == "yes")
        {
            Player.CurrentLocation = World.LocationByID(World.LOCATION_ID_SPIDER_FIELD);
        }

    }
}
        