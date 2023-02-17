namespace MiniProject
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please input a character name");
            string name = Console.ReadLine();
            Story story = new Story(name);
            story.Intro();

        }
    }
}