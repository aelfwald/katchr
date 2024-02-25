namespace Katchr.Sales
{
    internal class ConsoleReceiptPrinter : IReceiptPrinter
    {
        public void Print(string receipt)
        {
            Console.Write(receipt);
        }
    }
}
