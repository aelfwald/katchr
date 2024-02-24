namespace Katchr.Sales;
/// <summary>
/// Defines a service that checks if an item type is excempt from basic tax.
/// </summary>
public interface ITaxExcemptChecker
{
    bool IsExcempt(ItemType itemType);
}
