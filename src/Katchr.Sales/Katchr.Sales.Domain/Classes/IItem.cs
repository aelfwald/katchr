
namespace Katchr.Sales;

public interface IItem
{
    int Quantity { get; }

    string Name { get; } 

    ItemDef ItemDef { get; }

    decimal Price { get; }

    bool IsImported { get; set; }
    decimal GetTaxRate();
}
