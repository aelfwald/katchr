namespace Katchr.Sales;

/// <summary>
/// Define a basic tax exempt sale item
/// </summary>
public class BasicTaxExemptItem : ItemDecorator
{
    public BasicTaxExemptItem(IItem item) : base (item)
    {
        item.TaxRate = 0;
    }
 }
