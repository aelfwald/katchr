namespace Katchr.Sales;

public class ItemDef
{
    public string Name 
    { 
        get; 
        set; 
    } = string.Empty;

    public HashSet<string> Aliases
    {
        get;
        set;
    } = new HashSet<string>();


    public ItemType ItemType
    {
        get; set;
    } = ItemType.NotSet; 
}
