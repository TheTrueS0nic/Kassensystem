namespace Kassensystem.DAL
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product? GetProductById(int productId);
        void InsertProduct(Product product);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
    }
}
