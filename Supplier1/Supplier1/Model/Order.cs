using System.ComponentModel.DataAnnotations;

namespace Supplier1.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
