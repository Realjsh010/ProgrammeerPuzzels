using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameerPuzzels1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rocks = new List<int>();
            Random rnd = new Random();
            int length = 0;


            ShowHelp();

            while(true)
            {
                string command = Console.ReadLine();
                if(command == "ShowHelp")
                {
                    ShowHelp();
                }
                if(command == "CreateRocks")
                {
                    CreateRandomRocks();
                }
                if(command == "ShowCurrentRocks")
                {
                    ShowRocks();
                }
                if (command == "SortRocks")
                {
                    SortRocks();
                }
            }

            void ShowHelp()
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("ShowHelp");
                Console.WriteLine("CreateRocks");
                Console.WriteLine("ShowCurrentRocks");
                Console.WriteLine("SortRocks");
                Console.WriteLine("WIP: CustomLength");
                Console.WriteLine("WIP: CustomRocks");
            }

            void CreateRandomRocks()
            {
                length = rnd.Next(1, 31);
                for (int i = 0; i < length; i++)
                {
                    int colour = rnd.Next(2);
                    if(colour == 0)
                    {
                        rocks.Add(1); //White
                    }
                    else
                    {
                        rocks.Add(0); //Red
                    }
                }
            
            }

            void ShowRocks()
            {
                Console.WriteLine();
                foreach (var rock in rocks)
                {
                    if(rock == 1)
                    {
                        Console.Write("W");
                    }
                    if(rock == 0)
                    {
                        Console.Write("R");
                    }
                }
            }

            void SortRocks()
            {
                if (length == 0)
                {
                Console.WriteLine("Create Rocks first please");
                }
                else
                {


                    int a;
                    int b;
                    bool mistake;

                    do
                    {
                        mistake = false;
                        for (int i = 0; i < length - 1; i++)
                        {
                            a = rocks[i];
                            b = rocks[i + 1];
                            if (a > b)
                            {
                                mistake = true;
                                rocks[i] = b;
                                rocks[i + 1] = a;
                            }
                        }
                    }
                    while (mistake);
                }
            }


        }
    }
}
