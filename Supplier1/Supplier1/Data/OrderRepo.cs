using Supplier1.Model;
using Supplier1.Data;

namespace Supplier1.Data
{
    public class OrderRepo
    {
        private AppDBContext dbContext;

        public OrderRepo(AppDBContext _dBContext)
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

        public bool AddOrder(Order order)
        {
            if (order != null)
            {
                dbContext.Orders.Add(order);
                return Save();
            }
            else
                return false;
        }

        public bool UpdateOrder(Order order)
        {
            if (order != null)
            {
                dbContext.Orders.Update(order);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteOrder(Order order)
        {
            if (order != null)
            {
                dbContext.Orders.Remove(order);
                return Save();
            }
            else
                return false;
        }
        public Order GetOrder(int id)
        {
            return dbContext.Orders.FirstOrDefault(pro => pro.Id == id);
        }

        public IEnumerable<Order> GetOrders()
        {
            return dbContext.Orders.ToList();
        }
    }
}
