namespace Katchr.Sales;

public interface ITaxExcemptChecker
{
    bool IsExcempt(ItemType itemType);
}
