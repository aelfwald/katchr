namespace Katchr.Sales;

/// <summary>
/// A service that processes a sale and generates a receipt.
/// </summary>
public interface ISalesProcessor
{
    void Process(
        string salesItems,
        IReceiptPrinter receiptProvider);
}
