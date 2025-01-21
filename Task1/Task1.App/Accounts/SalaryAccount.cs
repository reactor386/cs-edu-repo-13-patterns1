//-
using System;


namespace Task1.Accounts;

/// <summary>
/// зарплатный аккаунт
/// </summary>
public class SalaryAccount : IAccount
{
    public string Type { get => "Зарплатный"; }
    public double Balance { get; set; }
    public double Interest { get; set; }

    /// <summary>
    /// расчет процентной ставки по правилам банка
    /// </summary>
    public void GetProfit()
    {
        Interest = Balance * 0.5;
    }
}
