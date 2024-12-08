using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my interactive Console Calculator App!");
        DateTime now = DateTime.Now;
        Console.WriteLine($"It is currently: {now}");
        Console.WriteLine("");
        bool myProc = true;
        while (myProc)
        {
            Console.WriteLine("would you like to perform any calculations?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Input choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine("");

            if (choice == "Yes")
            {
                PerformCalculation();
            }
            else if (choice == "No")
            {
                Console.WriteLine("Have a nice day!");
                myProc = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input received...");
                Console.WriteLine("");
            }
        }
    }

    static void PerformCalculation()
    {
        Console.Write("Enter the first number: ");
        if (double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.Write("Enter the second number: ");
            if (double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Choose Operation:");
                Console.WriteLine("1: +");
                Console.WriteLine("2: -");
                Console.WriteLine("3: *");
                Console.WriteLine("4: /");
                Console.Write("Input choice: ");
                string operation = Console.ReadLine();
                Console.WriteLine("");

                if (operation == "+")
                {
                    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
                    Console.WriteLine("");
                }
                else if (operation == "-")
                {
                    Console.WriteLine($"The difference of {num1} and {num2} is {num1 - num2}");
                    Console.WriteLine("");
                }
                else if (operation == "*")
                {
                    Console.WriteLine($"The Product of {num1} and {num2} is {num1 * num2}");
                    Console.WriteLine("");
                }
                else if (operation == "/")
                {
                    Console.WriteLine($"The qoutient of {num1} and {num2} if {num1 / num2}");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Invalid choice of operation...");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice for Num2...");
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice for Num1...");
            Console.WriteLine("");
        }
    }
}