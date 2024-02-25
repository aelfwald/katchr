namespace Katchr.Sales;

/// <summary>
/// Decorator for <see cref="Item"/>
/// </summary>
public abstract class ItemDecorator(Item item) : Item
{
    protected Item item = item;

    public override int Quantity
    {
        get
        {
            return item.Quantity;
        }
    }

    public override decimal Price
    {
        get
        {
            return item.Price;
        }
    }

    public override ItemDef ItemDef
    {
        get
        {
            return item.ItemDef;
        }
    }

    public override abstract decimal TaxRate { get; }

    public override abstract bool IsImported { get; }

}
