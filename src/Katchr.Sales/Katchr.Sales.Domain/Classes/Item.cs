namespace Katchr.Sales;

/// <summary>
/// Defines a sale item.
/// </summary>
public abstract class Item
{
    private decimal? _tax = null;

    protected Item()
    {
        ItemDef = new ItemDef();
    }

    public virtual int Quantity
    {
        get;
        protected set;
    }

    public virtual string Name
    {
        get
        {
            return $"{(IsImported ? "imported " : "")}{this.ItemDef.Name}";
        }
    }

    public virtual decimal Price
    {
        get;
        protected set;
    }

    public virtual ItemDef ItemDef
    {
        get;
        protected set;
    }

    protected decimal CalculateTax(decimal taxRate)
    {
        decimal np = taxRate * Price;
        return Math.Ceiling((np / 100) * 20) / 20;
    }

    public decimal Tax 
    { 
        get
        {
            if (!_tax.HasValue)
            {
                _tax = CalculateTax(TaxRate);
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

    public abstract decimal TaxRate { get; }

    public abstract bool IsImported { get; }

}
