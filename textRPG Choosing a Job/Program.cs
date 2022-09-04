using System;
using System.Numerics;
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

        enum MonsterType
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3
        }
    

        struct Monster
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

        static void CreateRandomMonster(out Monster monster)
        {
            Random rand = new Random();
            int randMonster = rand.Next(1, 4);
            switch (randMonster)
            {
                case (int)MonsterType.Slime:
                    Console.WriteLine("슬라임 스폰");
                    monster.hp = 2;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.Orc:
                    Console.WriteLine("오크 소환");
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.Skeleton:
                    Console.WriteLine("스켈레톤 소환");
                    monster.hp = 50;
                    monster.attack = 12;
                    break;
                default:
                    monster.hp = 0;
                    monster.attack = 0;
                    break;

            }
        }
        static void Fight(ref Player player , ref Monster monster)
        {
            while(true)
            {
                monster.hp -= player.attack;
                if(monster.hp <= 0)
                {
                    Console.WriteLine("승리");
                    Console.WriteLine($"남은체력 : {player.hp}");
                    break;
                }

                player.hp -= monster.attack;
                if(player.hp <= 0)
                {
                    Console.WriteLine("패배");
                    break;
                }
            }
        }
        static void EnterField(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("필드에 접속했습니다!");

                //몬스터
                Monster monster;
                CreateRandomMonster(out monster);

                Console.WriteLine("[1] 전투모드");
                Console.WriteLine("[2] 일정 확률로 마을로 도망");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    Fight (ref player, ref monster);
                }
                else if (input == "2")
                {
                    Random rand = new Random();
                    int randValue = rand.Next(0, 101);
                    if(randValue <=33)
                    {
                        Console.WriteLine("도망 성공");
                        break;
                    }
                    else
                    {
                        Fight(ref player, ref monster);
                    }
                }
            }
        }
        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("게임에 접속했습니다!");
                Console.WriteLine("[1] 필드로간다");
                Console.WriteLine("[2] 로비로 돌아가기");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    EnterField(ref player);
                }
                else if (input == "2")
                {
                    break;
                }
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

                    EnterGame(ref player);
                }
            }
        }
    }
}


          
    
