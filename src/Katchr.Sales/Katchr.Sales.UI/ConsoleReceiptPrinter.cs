namespace Katchr.Sales
{
    internal class ConsoleReceiptPrinter : IReceiptPrinter
    {
        public void PrintReceipt(string receipt)
        {
            Console.Write(receipt);
        }
    }
}
