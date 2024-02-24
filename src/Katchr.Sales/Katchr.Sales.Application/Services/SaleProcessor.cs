

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
        Basket basket = _basketBuilder.Build(salesItems);
        receiptProvider.PrintReceipt(basket.GenerateReceipt());
    }

}
