using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameerPuzzels4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ShowHelp();

            while (true)
            {
                Commands(Console.ReadLine());
            }

            void Commands(string command)
            {
                if (command == "ShowHelp")
                {
                    ShowHelp();
                }
                if (command == "SimulateRabbits")
                {
                    Simulate();
                }
            }

            void ShowHelp()
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("ShowHelp");
                Console.WriteLine("SimulateRabbits");
            }

            void Simulate()
            {
                int a = 0;
                int b = 2;

                for (int i = 0; i < 12; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                    Console.WriteLine(b);
                }
                Console.WriteLine(b);
            }

        }
    }
}
