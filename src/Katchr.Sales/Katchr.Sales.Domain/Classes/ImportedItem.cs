namespace Katchr.Sales;

/// <summary>
/// Defines an imported sale.
/// </summary>
public class ImportedItem : ItemDecorator
{
    public ImportedItem(IItem item) : base(item)
    {
        item.TaxRate += 5.00M;
        item.IsImported = true;
    }
}
