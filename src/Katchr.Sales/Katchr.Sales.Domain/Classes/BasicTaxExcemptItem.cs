namespace Katchr.Sales
{
    public class BasicTaxExcemptItem : ItemDecorator
    {
        public BasicTaxExcemptItem(IItem item) : base (item)
        {
            item.TaxRate = 0;
        }
     }
}
