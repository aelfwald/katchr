namespace Katchr.Sales;

/// <summary>
/// A repository for the <see cref="ItemDef"/>
/// Returns dummy data.
/// </summary>
public class ItemDefRepository : IItemDefRepository
{

    private Dictionary<string, ItemDef>? _itemDefLookUpMock;

    private static IEnumerable<ItemDef> TestData
    {
        get
        {

            yield return new ItemDef()
            {
                Name = "book",
                Aliases = [],
                ItemType = ItemType.Book
            };
            yield return new ItemDef()
            {
                Name = "music CD",
                Aliases = [],
                ItemType = ItemType.Misc
            };
            yield return new ItemDef()
            {
                Name = "chocolate bar",
                Aliases = [],
                ItemType = ItemType.Food
            };
            yield return new ItemDef()
            {
                Name = "box of chocolates",
                Aliases = ["box of imported chocolates", "imported box of chocolates"],
                ItemType = ItemType.Food
            };
            yield return new ItemDef()
            {
                Name = "bottle of perfume",
                Aliases = ["imported bottle of perfume"],
                ItemType = ItemType.Misc
            };
            yield return new ItemDef()
            {
                Name = "packet of headache pills",
                Aliases = ["packet of paracetamol"],
                ItemType = ItemType.Medical
            };

        }
    }

    public void InitItemDefLookUpMock()
    {
        if(_itemDefLookUpMock != null)
        {
            return;
        }

        _itemDefLookUpMock = [];

        foreach (ItemDef itemDef in TestData) 
        { 
            _itemDefLookUpMock.Add(itemDef.Name.ToLower(), itemDef);

            foreach (string alias in itemDef.Aliases)
            {
                _itemDefLookUpMock.Add(alias.ToLower(), itemDef);
            }
        }
    }

    public ItemDef GetItemDefByName(string name)
    {
        InitItemDefLookUpMock();
        return _itemDefLookUpMock![name.ToLower().Trim()];
    }
}
