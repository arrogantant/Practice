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

            static void Main(string[] args)
            {


                while (true)
                {

                    ClassType choice = ChooseClass();
                    if (choice != ClassType.None)
                        break;

                }
            }
        }
    }
