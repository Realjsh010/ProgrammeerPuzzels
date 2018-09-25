using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrameerPuzzels5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<bool> lockedNumbers = new List<bool>();
            List<int> userInput = new List<int>();
            List<int> computerInput = new List<int>();

            ShowHelp();

            while (true)
            {
                Commands(Console.ReadLine());
            }

            void Commands(string command)
            {
                if(command == "ShowHelp")
                {
                    ShowHelp();
                }
                if(command.Contains("InputCode"))
                {
                    InputCode(command.Substring(10));
                }
                if (command == "CompStartGuessing")
                {
                    CompStartGuessing();
                }
            }

            void ShowHelp()
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("ShowHelp");
                Console.WriteLine("InputCode@putbitcodehereanysize");
                Console.WriteLine("CompStartGuessing");
            }

            void InputCode(string uCode)
            {
                for (int i = 0; i < uCode.Length; i++)
                {
                    userInput.Add(Convert.ToInt16(uCode.Substring(i, 1)));
                }
                Console.WriteLine("Your inputted code is: ");
                foreach (var number in userInput)
                {
                    Console.Write(number);
                }
            }

            void CompStartGuessing()
            {
                bool first = true;
                int length = 0;
                foreach (var number in userInput)
                {
                    length++;
                }

                for (int i = 0; i < length; i++)
                {
                    lockedNumbers.Add(false);
                }
                while (lockedNumbers.Contains(false))
                {
                    for (int i = 0; i < length;/*notsure*/ i++)
                    {
                        if (!lockedNumbers[i])
                        {
                            if (first)
                            {
                                computerInput.Add(rnd.Next(0, 2));
                            }
                            else
                            {
                                computerInput[i] = rnd.Next(0, 2);
                            }
                            if ((computerInput[i] == userInput[i]) && !first)
                            {
                                lockedNumbers[i] = true;
                            }
                        }                        
                    }
                    first = false;
                    foreach (var number in computerInput)
                    {
                        Console.Write(number + " ");
                    }
                    Console.WriteLine();

                    //foreach (var bol in lockedNumbers)
                    //{
                    //    if (bol)
                    //    {
                    //        Console.Write("true ");
                    //    }
                    //    else
                    //    {
                    //        Console.Write("false ");
                    //    }
                    //}
                    //Console.WriteLine();
                }
            }
        }
    }
}
