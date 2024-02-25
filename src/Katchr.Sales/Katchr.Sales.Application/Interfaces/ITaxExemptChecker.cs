namespace Katchr.Sales;
/// <summary>
/// Defines a service that checks if an item type is exempt from basic tax.
/// </summary>
public interface ITaxExemptChecker
{
    bool IsExempt(ItemType itemType);
}
