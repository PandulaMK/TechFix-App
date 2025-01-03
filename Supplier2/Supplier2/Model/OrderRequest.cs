using System.ComponentModel.DataAnnotations;

namespace Supplier2.Model
{
    public class OrderRequest
    {
        [Key]
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
