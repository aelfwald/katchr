namespace Katchr.Sales;

public class ItemType
{
    public static ItemType NotSet { get; } = new ItemType();
    public static ItemType Food { get; } = new ItemType();
    public static ItemType Book { get; } = new ItemType();
    public static ItemType Medical { get; } = new ItemType();  
    public static ItemType Misc { get; } = new ItemType();

}
