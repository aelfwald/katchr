namespace Katchr.Sales;

/// <summary>
/// Calculates the tax value for a given item price
/// </summary>
public class TaxCalc
{
    public decimal Calc(decimal price, decimal taxRate)
    {
        decimal np = taxRate * price;
        return Math.Ceiling((np / 100) * 20) / 20;
    }
}
