namespace Katchr.Sales;

/// <summary>
/// Defines a service that outputs receipt details.
/// </summary>
public interface IReceiptPrinter
{
    void PrintReceipt(string receipt);
}
