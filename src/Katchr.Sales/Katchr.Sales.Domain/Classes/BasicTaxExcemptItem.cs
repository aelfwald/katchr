namespace Katchr.Sales
{
    public class BasicTaxExcemptItem(IItem item) : ItemDecorator(item)
    {
        public override decimal GetTaxRate()
        {
            return 0.00M;
        }
    }
}
