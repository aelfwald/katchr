
namespace Katchr.Sales;

public interface IItem
{
    int Quantity { get; }

    string Name { get; } 

    ItemDef ItemDef { get; }

    decimal Price { get; }

    decimal Tax { get; }

    decimal PriceIncTax { get; }

    bool IsImported { get; internal set; }

    decimal TaxRate { get; internal set; }
}
