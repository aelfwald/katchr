namespace Katchr.Sales;

public abstract class ItemDecorator(IItem item) : IItem
{
    protected IItem item = item;

    public int Quantity
    {
        get
        {
            return item.Quantity;
        }
    }

    public string Name
    {
        get
        {
            return item.Name;
        }
    }

    public decimal Price
    {
        get
        {
            return item.Price;
        }
    }

    public bool IsImported
    {
        get
        {
            return item.IsImported;
        }
        set
        {
            item.IsImported = value;
        }
    }


    public ItemDef ItemDef
    {
        get
        {
            return item.ItemDef;
        }
    }

    public virtual decimal GetTaxRate()
    {
        return item.GetTaxRate();
    }
}
