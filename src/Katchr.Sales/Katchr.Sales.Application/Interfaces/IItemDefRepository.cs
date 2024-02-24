namespace Katchr.Sales;

/// <summary>
/// Defines a repository for <see cref="ItemDef"/>
/// </summary>
public interface IItemDefRepository
{
    ItemDef GetItemDefByName(string name);
}
