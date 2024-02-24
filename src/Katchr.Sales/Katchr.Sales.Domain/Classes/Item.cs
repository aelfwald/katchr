namespace Katchr.Sales;

/// <summary>
/// Defines sale item at the basic tax rate.
/// </summary>
public class Item: IItem
{
    private decimal? _tax = null;

    public Item(
        int quantity,
        decimal price,
        ItemDef itemDef,
        TaxCalc taxCalc)
    {
        Quantity = quantity;
        Price = price;  
        ItemDef = itemDef;
        TaxCalc = taxCalc;  
    }

    public int Quantity 
    { 
        get; 
    }

    public string Name
    {
        get
        {
            return  $"{(IsImported ? "imported " : "")}{this.ItemDef.Name}";
        }
    }

    public decimal Price 
    { 
        get; 
    }

    public bool IsImported 
    { 
        get; 
        set; 
    }

    public ItemDef ItemDef
    {
        get;
    }
    
    public decimal TaxRate
    {
        get;
        set;
    } = 10.00M;

    public decimal Tax
    {
        get
        {
            if (!_tax.HasValue)
            {
                _tax = TaxCalc.Calc(Price, TaxRate);
            }

            return _tax.Value;

        }
    }

    public decimal PriceIncTax
    {
        get
        {
            return Price + Tax;
        }
    }

    internal TaxCalc TaxCalc
    {
        get;
        set;
    }
}
