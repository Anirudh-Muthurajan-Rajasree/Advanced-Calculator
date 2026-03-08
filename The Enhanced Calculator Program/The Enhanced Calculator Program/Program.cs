using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        double memory = 0;
        List<string> history = new List<string>();

        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("»»—»»——»»-|~|-««——««—«");
            Console.WriteLine("ANIRUDH M.R ADVANCED CALCULATOR");
            Console.WriteLine("»»—»»——»»-|~|-««——««—«");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("1  - Add");
            Console.WriteLine("2  - Subtract");
            Console.WriteLine("3  - Multiply");
            Console.WriteLine("4  - Divide");
            Console.WriteLine("5  - Exponent");
            Console.WriteLine("6  - Square Root");
            Console.WriteLine("7  - Percentage");
            Console.WriteLine("8  - Modulus");
            Console.WriteLine("9  - Show History");
            Console.WriteLine("10 - Memory Add (M+)");
            Console.WriteLine("11 - Memory Subtract (M-)");
            Console.WriteLine("12 - Memory Recall (MR)");
            Console.WriteLine("13 - Memory Clear (MC)");
            Console.WriteLine("14 - Exit");

            Console.Write("\nEnter choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
                continue;

            if (choice == 14)
                break;

            if (choice == 9)
            {
                Console.WriteLine("\nCalculation History:");
                foreach (var item in history)
                    Console.WriteLine(item);

                Console.ReadKey();
                continue;
            }

            if (choice == 12)
            {
                Console.WriteLine($"Memory Value: {memory}");
                Console.ReadKey();
                continue;
            }

            if (choice == 13)
            {
                memory = 0;
                Console.WriteLine("Memory Cleared");
                Console.ReadKey();
                continue;
            }

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
                continue;

            double num2 = 0;

            if (choice != 6)
            {
                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out num2))
                    continue;
            }

            double result = 0;
            string record = "";

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    record = $"{num1} + {num2} = {result}";
                    break;

                case 2:
                    result = num1 - num2;
                    record = $"{num1} - {num2} = {result}";
                    break;

                case 3:
                    result = num1 * num2;
                    record = $"{num1} * {num2} = {result}";
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        Console.ReadKey();
                        continue;
                    }
                    result = num1 / num2;
                    record = $"{num1} / {num2} = {result}";
                    break;

                case 5:
                    result = Math.Pow(num1, num2);
                    record = $"{num1}^{num2} = {result}";
                    break;

                case 6:
                    result = Math.Sqrt(num1);
                    record = $"√{num1} = {result}";
                    break;

                case 7:
                    result = (num1 / 100) * num2;
                    record = $"{num1}% of {num2} = {result}";
                    break;

                case 8:
                    result = num1 % num2;
                    record = $"{num1} % {num2} = {result}";
                    break;

                case 10:
                    memory += num1;
                    Console.WriteLine($"Memory: {memory}");
                    Console.ReadKey();
                    continue;

                case 11:
                    memory -= num1;
                    Console.WriteLine($"Memory: {memory}");
                    Console.ReadKey();
                    continue;

                default:
                    continue;
            }

            history.Add(record);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nResult: {result}");
            Console.ResetColor();

            Console.ReadKey();
        }

        Console.WriteLine("\nThanks for using Anirudh M.R Advanced Calculator!");
    }
}