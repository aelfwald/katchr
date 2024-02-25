namespace Katchr.Sales;

/// <summary>
/// A repository for the <see cref="ItemDef"/>
/// Returns dummy data.
/// </summary>
public class ItemDefRepository : IItemDefRepository
{

    private readonly List<ItemDef> _itemDefs =
    [
        new()
        {
            Name = "book",
            Aliases = [],
            ItemType = ItemType.Book
        },
        new()
        {
            Name = "music CD",
            Aliases = [],
            ItemType = ItemType.Misc
        },
        new()
        {
            Name = "chocolate bar",
            Aliases = [ "chocolate bar" ],
            ItemType = ItemType.Food
        },
        new()
        {
            Name = "box of chocolates",
            Aliases = [ "box of imported chocolates", "imported box of chocolates" ],
            ItemType = ItemType.Food
        },
        new()
        {
            Name = "bottle of perfume",
            Aliases = [ "imported bottle of perfume" ],
            ItemType = ItemType.Misc
        },
        new()
        {
            Name = "packet of headache pills",
            Aliases = [ "packet of paracetamol" ],
            ItemType = ItemType.Medical
        }
    ];

    public ItemDef GetItemDefByName(string name)
    {
       
        return _itemDefs.First(
                i =>
                     string.Equals(i.Name, name.Trim(),  StringComparison.OrdinalIgnoreCase)
                     || i.Aliases.Contains(name.ToLower().Trim()));
    }
}
