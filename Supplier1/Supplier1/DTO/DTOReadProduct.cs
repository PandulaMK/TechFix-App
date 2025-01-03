using System.ComponentModel.DataAnnotations;

namespace Supplier1.DTO
{
    public class DTOReadProduct
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int AvailableStock { get; set; }
        public decimal Price { get; set; }
    }
}
