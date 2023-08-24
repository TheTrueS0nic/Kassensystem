using System.Text.Json;

namespace Kassensystem.DAL
{
    public class ProductRepository : IProductRepository
    {
        
        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            string text = File.ReadAllText(@"C:\Users\dustin.dyckmanns\source\repos\Kassensystem\Kassensystem\Products.json");
            var products = JsonSerializer.Deserialize<IEnumerable<Product>>(text);
            return products;
            //throw new NotImplementedException();
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
