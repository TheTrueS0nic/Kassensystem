namespace Kassensystem.DAL
{
    public interface IProductDAL 
    {
        List<Product> SelectAllProducts();
    }
    public class ProductDAL : IProductDAL
    {
        public List<Product> SelectAllProducts() 
        {
            List<Product> ListProducts = new List<Product>
            {
                new Product {ProductId = 1, Name = "Sandwich-Toast Vollkorn", Description = "Weizenvollkorntoast mit 58% Weizenvollkornmehl", Price = 0.89},
            };
            return ListProducts;
        }
    }
}
