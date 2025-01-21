//-
using System;


namespace Task1.Accounts;

/// <summary>
/// обычный аккаунт
/// </summary>
public class OrdinaryAccount : IAccount
{
    public string Type { get => "Обычный"; }
    public double Balance { get; set; }
    public double Interest { get; set; }
    
    /// <summary>
    /// расчет процентной ставки по правилам банка
    /// </summary>
    public void GetProfit()
    {
        Interest = Balance * 0.4;

        if (Balance < 1000)
            Interest -= Balance * 0.2;

        if (Balance >= 1000)
            Interest -= Balance * 0.4;
    }
}
