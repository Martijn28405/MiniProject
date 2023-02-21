namespace MiniProject
{
    public class PlayerQuest
    {
        public Quest TheQuest;
        public bool IsCompleted;

        public PlayerQuest(Quest theQuest, bool isCompleted)
        {
            TheQuest = theQuest;
            IsCompleted = isCompleted;

        }
    }
}