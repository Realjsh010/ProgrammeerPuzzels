using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameerPuzzels2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Scientist> scientists = new List<Scientist>();           

            ShowHelp();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Help")
                {
                    ShowHelp();
                }
                if (command == "GetScientists")
                {
                    GetScientistsFromDocument();
                }
                if(command == "ShowScientists")
                {
                    foreach (var scientist in scientists)
                    {
                        Console.WriteLine(scientist.Name);
                        Console.WriteLine(scientist.BirthYear);
                        Console.Write("   ");
                        Console.Write(scientist.DeathYear);
                    }
                }
                if(command == "WhenMostLive")
                {
                    Console.WriteLine(CheckWhenMostAlive());
                }
            }

            // Methodes
            void ShowHelp()
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("Help");
                Console.WriteLine("GetScientists");
                Console.WriteLine("ShowScientists");
                Console.WriteLine("WhenMostLive");
            }

            void GetScientistsFromDocument()
            {

                string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Joris\Documents\Semester 2 Periode 1\ProgrameerPuzzels\Scientists.txt");

                foreach (string line in lines)
                {

                    string n1 = line.Substring(0, line.IndexOf(";"));
                    string n2 = line.Substring(line.IndexOf(";") + 1, 4);
                    string n3 = line.Substring(line.LastIndexOf(";") + 1, 4);

                    int gby = Convert.ToInt32(n2);
                    int dty = Convert.ToInt32(n3);

                    Scientist s = new Scientist(n1, gby, dty);
                    scientists.Add(s);
                }
            }

            string CheckWhenMostAlive()
            {

                int mostScientists = 0;
                int bestYear = 0;
                int minYear = scientists[0].BirthYear;
                int maxYear = scientists[0].DeathYear;

                foreach (var scientist in scientists)
                {
                    if(scientist.BirthYear < minYear)
                    {
                        minYear = scientist.BirthYear;
                    }
                    if(scientist.DeathYear > maxYear)
                    {
                        maxYear = scientist.DeathYear;
                    }
                }

                for (int i = minYear; i < maxYear; i++)
                {
                    int count = 0;
                    foreach (var scientist in scientists)
                    {
                        if(scientist.BirthYear < i && scientist.DeathYear > i)
                        {
                            count++;
                        }
                    }
                    if(mostScientists < count)
                    {
                        mostScientists = count;
                        bestYear = i;
                    }
                }
                return Convert.ToString(bestYear);
            }

        }
    }
}
