using System;
using System.Xml.Serialization;

namespace CSharp
{
    class Program
    {
        enum ClassType
        {
            None = 0,
            knight = 1,
            Ardher = 2,
            Mage = 3,
            cat = 4,
        }

        struct Player
        {
            public int hp;
            public int attack;
            
        }

        static ClassType ChooseClass()
        {
            Console.WriteLine("직업을 선택하세여");
            Console.WriteLine("[1]기사");
            Console.WriteLine("[2]궁수");
            Console.WriteLine("[3]법사");
            Console.WriteLine("[4]고양이");

            ClassType choice = ClassType.None;
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    choice = ClassType.knight;
                    break;
                case "2":
                    choice = ClassType.Ardher;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
                case "4":
                    choice = ClassType.cat;
                    break;


            }

            return choice;
        }

        

        static void CreatePlayer(ClassType choice, out Player player)
        {
            
            switch (choice)
            {
                case ClassType.knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Mage:
                    player.hp = 80;
                    player.attack = 8;
                    break;
                case ClassType.Ardher:
                    player.hp = 60;
                    player.attack = 12;
                    break;
                case ClassType.cat:
                    player.hp = 1000;
                    player.attack = 1000;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

            static void Main(string[] args)
            {

                while (true)
                {

                    ClassType choice = ChooseClass();
                    if (choice != ClassType.None)
                {
                    Player player;

                    CreatePlayer(choice, out player);

                    Console.WriteLine($"HP{player.hp} Attack{player.attack}");
                }
                    

                }
            }
        }
    }
