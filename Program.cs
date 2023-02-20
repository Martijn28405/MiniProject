using MiniProject.Quests;

namespace MiniProject
{
    public class Program
    {
        public static void Main()
        {
            GuardPost gp = new GuardPost(1, "Guard's post");
            gp.startQuest();
            // Console.WriteLine("Please input a character name");
            // string name = Console.ReadLine();
            // Story story = new Story(name);
            // story.Intro();
            // story.Menu();
        }
    }
}