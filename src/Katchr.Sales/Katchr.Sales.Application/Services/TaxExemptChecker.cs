namespace Katchr.Sales;


/// <summary>
/// A service that checks if an item type is exempt from tax.
/// </summary>
public class TaxExemptChecker : ITaxExemptChecker
{

    private readonly HashSet<ItemType> _exemptTypes =
        [
            ItemType.Medical,
            ItemType.Book,
            ItemType.Food
        ];

    public bool IsExempt(ItemType itemType)
    {
        return _exemptTypes.Contains(itemType);
    }
}
