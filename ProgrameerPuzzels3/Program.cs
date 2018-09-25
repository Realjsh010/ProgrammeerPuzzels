using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameerPuzzels3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<bool> lights = new List<bool>();
            int amount = 0;


            ShowHelp();

            while (true)
            {
                CommandList(Console.ReadLine());
            }

            void CommandList(string command)
            {
                if (command == "ShowHelp")
                {
                    ShowHelp();
                }
                if (command == "CreateLights")
                {
                    CreateLights();
                    ShowLights();
                }
                if (command == "ShowLights")
                {
                    ShowLights();
                }
                if (command.Contains("SwitchKey"))
                {
                    SwitchKey(Convert.ToInt16(command.Substring(9)));
                }
                if (command == "Solve")
                {
                    Solve();
                }
            }

            void ShowHelp()
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("ShowHelp");
                Console.WriteLine("CreateLights");
                Console.WriteLine("ShowLights");
                Console.WriteLine("SwitchKey#");
                Console.WriteLine("Solve");
            }

            void CreateLights()
            {
                amount = rnd.Next(3, 21);
                //amount = 5;
                for (int i = 0; i < amount; i++)
                {
                    lights.Add(false);
                }
                for (int i = 0; i < 100; i++)
                {
                    SwitchKey(rnd.Next(1, amount));
                }
                ShowLights();
            }

            void ShowLights()
            {
                Console.WriteLine();
                foreach (var light in lights)
                {
                    if (!light)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("I ");
                    }
                }
            }

            void SwitchKey(int index)
            {

                lights[index - 1] = !lights[index - 1];
                if (index == 1)
                {
                    lights[amount - 1] = !lights[amount - 1];
                    lights[index] = !lights[index];
                }
                else if (index == amount)
                {
                    lights[0] = !lights[0];
                    lights[index - 2] = !lights[index - 2];
                }
                else
                {
                    lights[index - 2] = !lights[index - 2];
                    lights[index] = !lights[index];
                }
            }

            void Solve()
            {
                bool done = true;
                do
                {
                    done = true;
                    if (lights.Contains(false))
                    {
                        done = false;
                        SwitchKey(rnd.Next(1, amount));
                        ShowLights();
                    }
                }
                while (!done);
                ShowLights();
            }

            //bool UnsolvedCheck()
            //{
            //    foreach (var light in lights)
            //    {
            //        if (!light)
            //        {
            //            return true; ;
            //        }
            //    }
            //    return false;
            //}
        }
    }
}
