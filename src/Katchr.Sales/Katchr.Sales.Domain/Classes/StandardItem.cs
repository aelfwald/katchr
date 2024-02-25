namespace Katchr.Sales;

/// <summary>
/// Defines sale item at the basic tax rate.
/// </summary>
public class StandardItem: Item
{
    public StandardItem(
       int quantity,
       decimal price,
       ItemDef itemDef)
    {
        Quantity = quantity;
        Price = price;
        ItemDef = itemDef;
    }

    public override decimal TaxRate
    {
        get
        {
            return 10.00M; 
        }
    }

    public override bool IsImported
    {
        get
        {
            return false;
        }
    }

}
