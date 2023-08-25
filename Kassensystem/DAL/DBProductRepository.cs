using Microsoft.EntityFrameworkCore;

namespace Kassensystem.DAL
{
    public class DBProductRepository : IProductRepository
    {
        private readonly DbContext _dbContext;
        public DBProductRepository(DbContext dbContext) 
        { 
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public Product? GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
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
