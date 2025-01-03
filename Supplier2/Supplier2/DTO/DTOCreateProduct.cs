using System.ComponentModel.DataAnnotations;
namespace Supplier2.DTO
{
    public class DTOCreateProduct
    {
        public string ProductName { get; set; }
        public int AvailableStock { get; set; }
        public decimal Price { get; set; }
      
    }
}
