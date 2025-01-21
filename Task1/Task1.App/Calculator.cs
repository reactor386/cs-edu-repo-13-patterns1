//-
using System;

using Task1.Accounts;


namespace Task1.App;

/// <summary>
/// класс банковского калькулятора
/// </summary>
public static class Calculator
{
    /// <summary>
    /// метод, запускающий расчет процентной ставки на аккаунте
    /// </summary>
    /// <param name="account">банковский аккаунт</param>
    public static void CalculateInterest(IAccount account) 
    {
        account.GetProfit();
    }
}
