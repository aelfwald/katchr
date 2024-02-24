namespace Katchr.Sales;

public interface ISalesProcessor
{
    void Process(
        string salesItems,
        IReceiptPrinter receiptProvider);
}
