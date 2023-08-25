using System.Text.Json;

namespace Kassensystem.DAL
{
    public class JSONProductRepository : IProductRepository
    {
        private const string ProductJson = @"C:\Users\dustin.dyckmanns\source\repos\Kassensystem\Kassensystem\Products.json";
        public void DeleteProduct(int productId)
        {
            string text = File.ReadAllText(ProductJson);
            var products = JsonSerializer.Deserialize<IList<Product>>(text);
            foreach (Product product in products)
            {
                if (product.ProductId == productId)
                {
                    products.Remove(product);
                    break;
                }
            }
            string jsonString = JsonSerializer.Serialize(products);
            File.WriteAllText(ProductJson, jsonString);
        }

        public Product? GetProductById(int productId)
        {
            string text = File.ReadAllText(ProductJson);
            var products = JsonSerializer.Deserialize<IEnumerable<Product>>(text);
            foreach(Product product in products)
            {
                if(product.ProductId== productId)
                {
                    return product;
                }
            }
            return null;
            
        }

        public IEnumerable<Product> GetProducts()
        {
            string text = File.ReadAllText(ProductJson);
            var products = JsonSerializer.Deserialize<IEnumerable<Product>>(text);
            return products;
            
        }

        public void InsertProduct(Product product)
        {
            string text = File.ReadAllText(ProductJson);
            var products = JsonSerializer.Deserialize<IList<Product>>(text);
            if(products == null) 
            {
                products = new List<Product>();
            }
            products.Add(product);
            string jsonString = JsonSerializer.Serialize(products);
            File.WriteAllText(ProductJson, jsonString);
            //throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            string text = File.ReadAllText(ProductJson);
            var products = JsonSerializer.Deserialize<IList<Product>>(text);
            foreach (Product product_ in products)
            {
                if (product_.ProductId == product.ProductId)
                {
                    products.Remove(product_);
                    products.Add(product);
                    break;
                }
            }
            string jsonString = JsonSerializer.Serialize(products);
            File.WriteAllText(ProductJson, jsonString);
        }
    }
}
