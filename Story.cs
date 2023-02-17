using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject
{
    public class Story
    {
        public Player player { get; set; }

        public Story(string playerName)
        {
            player = new Player(playerName)
            {
                CurrentWeapon = World.WeaponByID(World.WEAPON_ID_RUSTY_SWORD),
                CurrentLocation = World.LocationByID(World.LOCATION_ID_HOME)
            };
        }

        public void Intro()
        {
            Console.WriteLine("The people in your town are being terrorized by giant spiders. You Decide to do what you can to help");
        }
    }
}