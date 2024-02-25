namespace Katchr.Sales;

/// <summary>
/// Defines an imported sale item.
/// </summary>
public class ImportedItem(Item item) : ItemDecorator(item)
{
    public override decimal TaxRate
    {
        get
        {
            return item.TaxRate + 5.00M;
        }
    }

    public override bool IsImported
    {
        get
        {
            return true;
        }
    }

}
