//-
using System;


namespace Task1.Accounts;

/// <summary>
/// общий интерфейс для банковских аккаунтов
/// </summary>
public interface IAccount
{
    // тип учетной записи
    public string Type { get; }

    // баланс учетной записи
    public double Balance { get; set; }

    // процентная ставка
    public double Interest { get; set; }

    // выполнение расчета процентной ставки по правилам банка
    //  для текущего аккаунта
    public void GetProfit();
}
