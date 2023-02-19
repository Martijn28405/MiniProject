namespace MiniProject
{
    public class Battle
    {
        private Player _player { get; set; }
        private Monster _monster { get; set; }

        public Battle(Player player, Monster monster)
        {
            _player = player;
            _monster = monster;
        }

        public void StartBattle()
        {
            Console.WriteLine($"A wild {_monster.Name} appears!");

            while (_player.CurrentHitPoints > 0)
            {
                Console.WriteLine("What do you want to do?");
                char userChoice;
                while (true)
                {
                    Console.WriteLine("1. Attack\n2. Dodge\n3. Heal");
                    userChoice = Console.ReadKey().KeyChar;
                    Console.Clear();

                    if (userChoice == '1' || userChoice == '2' || userChoice == '3') break;

                    Console.WriteLine("You can't do that. Choose something else");
                }

                bool dodgeNextMove = false;

                switch (userChoice)
                {
                    case '1':
                        _player.DealDamage(_monster);
                        break;
                    case '2':
                        dodgeNextMove = Dodge();
                        break;
                    case '3':
                        _player.Recover();
                        break;
                }

                if (_monster.CurrentHitPoints <= 0)
                {
                    BattleWin();
                    return;
                }
                else
                {
                    Console.WriteLine($"The {_monster.Name} has {_monster.CurrentHitPoints} health left.");
                }

                if (!dodgeNextMove)
                {
                    _monster.DealDamage(_player);
                }

                Console.WriteLine($"You have {_player.CurrentHitPoints} health left.");
            }

            if (_player.CurrentHitPoints <= 0)
            {
                Console.WriteLine("You Died!");
            }
        }

        public bool Dodge()
        {
            Random rand = new Random();
            int chance = rand.Next(1, 3);
            if (chance == 1)
            {
                Console.WriteLine($"You dodged the {_monster.Name} attack!");
                return true;
            }
            else
            {
                Console.WriteLine("Dodge failed!");
                return false;
            }
        }

        private void BattleWin()
        {
            Console.WriteLine($"{_monster.Name} killed!");
            if (_monster.Loot != null)
            {
                Console.WriteLine($"You've obtained:");
                foreach (CountedItem item in _monster.Loot.TheCountedItemList)
                {
                    Console.WriteLine($"{item.Quantity}x {item.TheItem.Name}");
                    _player.Inventory.AddCountedItem(item);
                }
            }
        }
    }
}
