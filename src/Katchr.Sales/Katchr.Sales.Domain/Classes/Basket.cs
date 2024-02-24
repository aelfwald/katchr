using System.Text;

namespace Katchr.Sales;

/// <summary>
/// A basket of sale items.
/// </summary>
public class Basket
{
    private readonly List<IItem> _items = [];

    public void AddItem(IItem item)
    {
        _items.Add(item);
    }

    public string GenerateReceipt()
    {
        StringBuilder sb = new();

        decimal priceTotal = 0;
        decimal saleTax = 0;

        foreach(IItem item in _items) 
        {
            sb.AppendLine(@$"{item.Quantity} {item.Name}: {(item.PriceIncTax).ToString("N2")}");

            saleTax += item.Tax;
            priceTotal += item.Price;
        }

        sb.AppendLine($"Sales Taxes: {saleTax.ToString("N2")}");
        sb.AppendLine($"Total: {(priceTotal + saleTax).ToString("N2")}");

        return sb.ToString();
    }
}
