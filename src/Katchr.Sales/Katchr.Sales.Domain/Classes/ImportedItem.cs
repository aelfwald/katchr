namespace Katchr.Sales;

public class ImportedItem : ItemDecorator
{
    public ImportedItem(IItem item) : base(item)
    {
        item.TaxRate += 5.00M;
        item.IsImported = true;
    }
}
