namespace Katchr.Sales;

public class TaxExemptChecker : ITaxExcemptChecker
{

    private readonly HashSet<ItemType> _items =
        [
            ItemType.Medical,
            ItemType.Book,
            ItemType.Food
        ];

    public bool IsExcempt(ItemType itemType)
    {
        return _items.Contains(itemType);
    }
}
