

using Katchr.Sales;

namespace Katchr.Sales;

public class ItemDefRepository : IItemDefRepository
{

    private readonly List<ItemDef> _itemDefs =
    [
        new()
        {
            Name = "book",
            Aliases = [ "Book"],
            ItemType = ItemType.Book
        },
        new()
        {
            Name = "music CD",
            Aliases = [ "music cd"],
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
        },
        new()
        {
            Name = "bottle of perfume",
            Aliases = [ "packet of paracetamol" ],
            ItemType = ItemType.Misc
        },
    ];

    public ItemDef GetItemDefByName(string name)
    {
        return _itemDefs.First( i => i.Name == name.ToLower().Trim() || i.Aliases.Contains(name.ToLower().Trim()));
    }
}
