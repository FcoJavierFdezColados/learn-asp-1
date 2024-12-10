namespace ProductList.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Slug => ProductName.Replace(' ', '-');
    }
}
