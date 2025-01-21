//-
using System;
using System.Collections.Generic;

using Task1.Accounts;


namespace Task1.App;

/// <summary>
/// рассчет процентов по банковским аккаунтам
///  и вывод полученных значений
/// </summary>
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("---");
        int result = 0;

        List<IAccount> accounts = 
        [
            // обычный аккаунт
            new OrdinaryAccount() { Balance = 100 },

            // обычный аккаунт
            new OrdinaryAccount() { Balance = 2000 },

            // зарплатный аккаунт
            new SalaryAccount() { Balance = 1000 },
        ];

        foreach (IAccount account in accounts)
        {
            Calculator.CalculateInterest(account);

            Console.WriteLine($"{account.Type}");
            Console.WriteLine($"{account.Interest}");
        }

        Console.WriteLine("---");
        Console.WriteLine($"return: [{result}]");
        Console.ReadKey();
    }
}
