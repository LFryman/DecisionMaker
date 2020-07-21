using System;
using System.Reflection.Metadata.Ecma335;

namespace Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            bool lContinue = true;
            while (lContinue)
            {
                int num;

                Console.WriteLine(name + " please enter a number between 1 and 100.");
                //double num = double.Parse(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid Number,try again" + name);
                    Console.Write("Enter Number. ");
                }

                while (num < 1 || num > 100)
                {
                    Console.WriteLine("Try again.");
                    Console.WriteLine("Enter another number.");
                    num = int.Parse(Console.ReadLine());
                }

                if (num % 2 == 0 && num >= 2 && num <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (num % 2 == 0 && num >= 26 && num <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (num % 2 == 0 && num >60 && num <= 100)
                {
                    Console.WriteLine(num + "Even");
                }
                else
                {
                    Console.WriteLine(num + " Odd");
                }
                Console.WriteLine("Would you like to continue " + name + "?");
                string input = Console.ReadLine();

                if (input == "yes")
                {
                    lContinue = true;
                }
                else
                {
                    lContinue = false;
                    Console.WriteLine("Come again!");
                }

             }
        }
    }
}
