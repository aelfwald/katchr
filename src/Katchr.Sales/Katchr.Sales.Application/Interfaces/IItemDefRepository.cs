namespace Katchr.Sales;

public interface IItemDefRepository
{
    ItemDef GetItemDefByName(string name);
}
