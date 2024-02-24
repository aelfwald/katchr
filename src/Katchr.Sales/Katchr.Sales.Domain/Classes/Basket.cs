using System.Text;

namespace Katchr.Sales
{
    public class Basket
    {
        private readonly List<IItem> _items = [];
        private readonly TaxCalc _taxCalc = new();
        
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

                decimal itemTax = _taxCalc.Calc(item.Price, item.GetTaxRate());

                sb.AppendLine(@$"{item.Quantity} {item.Name}: {(item.Price + itemTax).ToString("N2")}");

                saleTax += itemTax;
                priceTotal += item.Price;
            }

            sb.AppendLine($"Sales Taxes: {saleTax.ToString("N2")}");
            sb.AppendLine($"Total: {(priceTotal + saleTax).ToString("N2")}");

            return sb.ToString();
        }
    }
}
