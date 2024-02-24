namespace Katchr.Sales;

/// <summary>
/// Define a basic tax excempt sale item
/// </summary>
public class BasicTaxExcemptItem : ItemDecorator
{
    public BasicTaxExcemptItem(IItem item) : base (item)
    {
        item.TaxRate = 0;
    }
 }
