using Kassensystem.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
            var product = GetProductById(productId);
            _dbContext.Set<Product>().Remove(product);
            _dbContext.SaveChanges();
        }

        public Product? GetProductById(int productId)
        {
            return _dbContext.Set<Product>().Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Set<Product>().ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Set<Product>().Add(product);
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Set<Product>().Update(product);
            _dbContext.SaveChanges();
        }
    }
}
