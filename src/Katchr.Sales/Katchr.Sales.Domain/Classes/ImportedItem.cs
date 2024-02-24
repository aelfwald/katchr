namespace Katchr.Sales
{
    public class ImportedItem : ItemDecorator
    {
        public ImportedItem(IItem item) : base(item)
        {
            item.IsImported = true;
        }

        public override decimal GetTaxRate()
        {
            return item.GetTaxRate() + 5.00M;
        }
    }
}
