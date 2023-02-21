namespace MiniProject
{
    public class Location
    {
        public int ID;
        public string Name;
        public string Description;
        public Item ItemRequiredToEnter;
        public Quest QuestAvailableHere;
        public Monster MonsterLivingHere;
        public Location LocationToNorth;
        public Location LocationToEast;
        public Location LocationToSouth;
        public Location LocationToWest;
        public string Letter;

        public Location(int id, string name, string description, Item itemRequiredToEnter, Quest questAvailableHere,
            Monster monsterLivingHere, string letter)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;
            Letter = letter;
        }

        public string Map()
        {
            string town = World.LocationByID(World.LOCATION_ID_TOWN_SQUARE).Letter;
            string garden = World.LocationByID(World.LOCATION_ID_ALCHEMISTS_GARDEN).Letter;
            string farmhouse = World.LocationByID(World.LOCATION_ID_FARMHOUSE).Letter;
            string farmfield = World.LocationByID(World.LOCATION_ID_FARM_FIELD).Letter;
            string hut = World.LocationByID(World.LOCATION_ID_ALCHEMIST_HUT).Letter;
            string guard = World.LocationByID(World.LOCATION_ID_GUARD_POST).Letter;
            string spider = World.LocationByID(World.LOCATION_ID_SPIDER_FIELD).Letter;
            string home = World.LocationByID(World.LOCATION_ID_HOME).Letter;
            string bridge = World.LocationByID(World.LOCATION_ID_BRIDGE).Letter;
            string map = "\n" + String.Format("{0,5}", garden) + "\n" + String.Format("{0,5}", hut) + "\n" + " " +
                         farmfield + farmhouse + town + guard + bridge + spider + "\n" + "    " + home + "\n";
            return $"Current Location: {Letter} \n Map \n {map}";  
        }

        public string Compass()
        {
            string north = (LocationToNorth != null) ? "    N\n    |" : "";
            string east = (LocationToEast != null) ? "---E" : "";
            string south = (LocationToSouth != null) ? "    |\n    S" : "";
            string west = (LocationToWest != null) ? "W---" : "    ";
            return "\n" + north + "\n" + west + "|" + east + "\n" + south;
        }
    }
}