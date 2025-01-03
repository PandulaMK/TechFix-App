using Supplier1.Model;
using Supplier1.Data;

namespace Supplier1.Data
{
    public class ProductRepo
    {
        private AppDBContext dbContext;

        public ProductRepo(AppDBContext _dBContext)
        {
            dbContext = _dBContext;
        }

        public bool Save()
        {
            int count = dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool AddProduct(Product product)
        {
            if (product != null)
            {
                dbContext.Products.Add(product);
                return Save();
            }
            else
                return false;
        }

        public bool UpdateProduct(Product product)
        {
            if (product != null)
            {
                dbContext.Products.Update(product);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteProduct(Product product)
        {
            if (product != null)
            {
                dbContext.Products.Remove(product);
                return Save();
            }
            else
                return false;
        }
        public Product GetProduct(int id)
        {
            return dbContext.Products.FirstOrDefault(pro => pro.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }
    }
}
