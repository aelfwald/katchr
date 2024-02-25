namespace Katchr.Sales;

/// <summary>
/// Define a basic tax exempt sale item
/// </summary>
public class BasicTaxExemptItem(Item item) : ItemDecorator(item)
{
    public override decimal TaxRate
    {
        get
        {
            return 0.00M;
        }
    }

    public override bool IsImported
    {
        get
        {
            return item.IsImported;
        }
    }
}
