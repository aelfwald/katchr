

using System.Text;

namespace Katchr.Sales;

/// <summary>
/// Service that marshals the processing of a sale.
/// </summary>
public class SaleProcessor(
    BasketBuilder basketBuilder) : ISalesProcessor
{
    private readonly BasketBuilder _basketBuilder = basketBuilder;

    public void Process(
        string salesItems, 
        IReceiptPrinter receiptProvider)
    {
        try
        {
            Basket basket = _basketBuilder.Build(salesItems);
            receiptProvider.Print(basket.GenerateReceipt());
        }
        catch(Exception ex) 
        {
            StringBuilder sb = new();
            sb.AppendLine("***********************************************");
            sb.AppendLine($"ERROR PROCSSING SALE: {ex.Message}");
            sb.AppendLine("***********************************************");

            receiptProvider.Print(sb.ToString());
        }

    }

}
