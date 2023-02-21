namespace MiniProject.Quests
{
    public class GuardPost
    {
        public int adventuresPass { get; set; }
        public string currentLocation { get; set; }

        public GuardPost(int adventuresPass, string currentLocation)
        {
            this.adventuresPass = adventuresPass;
            this.currentLocation = currentLocation;
        }

        public void startQuest()
        {
            if (currentLocation == "Guard's post")
            {
                Console.WriteLine("After going west you arrive at the Guard's post.\n Guard: Hello fellow! If you want to pass through here I will have to see your adventure's pass.");
                if (adventuresPass == 0)
                {
                    Console.WriteLine("Guard:Turn back at once, peasant! Unless thee hast proof of thy grit.");
                    Console.WriteLine("You need the Adventurer’s Pass to proceed to the bridge so you walk back to Town Square.");
                }
                //Switch location to Town Square
                else if (adventuresPass == 1)
                {
                    Console.WriteLine("Guard: Ahh I see you are quite a strong fella. Just the right peerson for this job.");
                    Console.WriteLine("Guard: Listen here adventurer. past this post there is a bridge. After crossing this bridge there will be a forest.");
                    Console.WriteLine("Guard: The problem is. There are giant spiders in the forest that are forming a big threat for us.");
                    Console.WriteLine("Guard: Could you please deal with these spiders for us? there will be an amazing reward for you if you manage to complete this quest.");
                    Console.WriteLine("Choose:\n1. Proceed to  bridge\n 2. Turn back to Town Square");
                    int choice = Int32.Parse(Console.ReadLine());
                    while (choice != 1 && choice != 2)
                    {
                        Console.WriteLine("Please Choose a valid option.");
                        Console.WriteLine("Choose:\n1. Proceed to  bridge\n 2. Turn back to Town Square");
                        choice = Int32.Parse(Console.ReadLine());
                    }
                    if (choice == 1)
                    {
                        System.Console.WriteLine("Guard: Thank you so much adventurer! Your heroic deed will be remembered by us.");
                        //Switch location to Bridge
                    }
                    else if (choice == 2)
                    {
                        System.Console.WriteLine("Guard: I would really appreciate it if you came back soon. Otherwise many lifes will be lost!");
                        //Switch location to Town Square
                    }
                }
            }
        }
    }
}