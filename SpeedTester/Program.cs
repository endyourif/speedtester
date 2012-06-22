using System;
using System.Threading;

namespace SpeedTester
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string input = Console.ReadLine().ToLower();
                string cmd;
                string arg = string.Empty;

                if (input.Contains(" "))
                {
                    cmd = input.Substring(0, input.IndexOf(' '));
                    arg = input.Substring(input.IndexOf(' ') + 1);
                }
                else
                {
                    cmd = input;
                }

                LinkChecker checker = new LinkChecker();

                switch (cmd.ToLower())
                {
                    case "start":
                        if (string.IsNullOrEmpty(arg))
                        {
                            Console.WriteLine("Please enter a location to check, e.g. dev, and try again");
                        }
                        else
                        {
                            checker.Check(arg, 100);
                        }
                        break;
                    case "quit":
                    case "exit":
                        Console.WriteLine("==Exiting");
                        return;
                }
            } while (true);
        }
    }
}
