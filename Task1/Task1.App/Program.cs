//-
using System;


namespace Task1.App;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("---");
        int result = 0;

        Account account = new() { Type = "Обычный", Balance = 100 };
        Calculator.CalculateInterest(account);

        Console.WriteLine($"{account.Type}");
        Console.WriteLine($"{account.Interest}");

        Console.WriteLine("---");
        Console.WriteLine($"return: [{result}]");
        Console.ReadKey();
    }
}
