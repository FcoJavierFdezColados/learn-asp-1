namespace ProductList.Models
{
    public class DataBase
    {
        public static List<Product> GetProducts()
        {
            List<Product> products =
            [
                new() 
                {
                    ProductId = 1,
                    ProductName = "Product 1",
                    Price = (decimal) 499.00
                },
                new() 
                {
                    ProductId = 2,
                    ProductName = "Best Product Ever",
                    Price = (decimal) 1109.00
                },
                new()
                {
                    ProductId = 3,
                    ProductName = "Third Product",
                    Price = (decimal)2017.00
                },
                new()
                {
                    ProductId = 4,
                    ProductName = "Worst Product Ever",
                    Price = (decimal)1480.99
                },
                new()
                {
                    ProductId = 5,
                    ProductName = "Some other Product",
                    Price = (decimal)290.00
                },
                new()
                {
                    ProductId = 6,
                    ProductName = "Sitxh Product",
                    Price = (decimal)405.00
                },
                new()
                {
                    ProductId = 7,
                    ProductName = "Still Another Product",
                    Price = (decimal)899.99
                },
                new()
                {
                    ProductId = 8,
                    ProductName = "Product Of the Month",
                    Price = (decimal)1499.99
                },
                new()
                {
                    ProductId = 9,
                    ProductName = "Nineth Product",
                    Price = (decimal)69.99
                },
                new() 
                {
                    ProductId = 10,
                    ProductName = "Final Product",
                    Price = (decimal)99.99
                }

            ];

            return products;
        }

        public static Product GetProduct(string slug)
        {
            List<Product> products = DataBase.GetProducts();
            foreach (Product product in products)
            {
                if(product.Slug == slug)
                {
                    return product;
                }
            }
            return null;
        }
    }
}
