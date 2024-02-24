namespace Katchr.Sales
{
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
