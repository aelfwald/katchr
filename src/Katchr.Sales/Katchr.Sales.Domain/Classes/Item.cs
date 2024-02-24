namespace Katchr.Sales;

public class Item: IItem
{
    public Item(
        int quantity,
        decimal price,
        ItemDef itemDef)
    {
        Quantity = quantity;
        Price = price;  
        ItemDef = itemDef;
    }

    public int Quantity 
    { 
        get; 
    }

    public string Name
    {
        get
        {
            return  $"{(IsImported ? "imported " : "")}{this.ItemDef.Name}";
        }
    }

    public decimal Price 
    { 
        get; 
    }

    public bool IsImported 
    { 
        get; 
        set; 
    }

    public ItemDef ItemDef
    {
        get;
    }

    public decimal GetTaxRate()
    {
        return 10.00M;
    }
}
