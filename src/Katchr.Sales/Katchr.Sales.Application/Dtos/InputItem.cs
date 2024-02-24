namespace Katchr.Sales
{
    /// <summary>
    /// Holds input to the sale processed that has been parsed.
    /// </summary>
    public class InputItem
    {
        public int Quantity 
        { 
            get;
            set; 
        }

        public decimal Price 
        { 
            get;
            set; 
        }      

        public string Name 
        { 
            get; 
            set; 
        } = string.Empty;   

        public  bool IsImported 
        { 
            get; 
            set; 
        }
    }
}
