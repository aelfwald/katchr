namespace Katchr.Sales;

/// <summary>
/// Item definition.
/// </summary>
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
    } = [];

    public ItemType ItemType
    {
        get; set;
    } = ItemType.NotSet; 
}
