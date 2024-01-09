namespace Course.Entities
{
    public class Product
    {
        public string Produto { get; set; }
        public double Price { get; set; }

        public Product()
        {
        } 
        public Product(string produto, double price)
        {
            Produto = produto;
            Price = price;
        }       
        
    }
}