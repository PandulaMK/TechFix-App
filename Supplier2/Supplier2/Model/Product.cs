using System.ComponentModel.DataAnnotations;
namespace Supplier2.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int AvailableStock { get; set; }
        public decimal Price { get; set; }
        
    }
}
