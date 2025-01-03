using Microsoft.AspNetCore.Mvc;
using Supplier2.Model;
using Supplier2.Data;
using System;

namespace Supplier2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly AppDBContext _context;

        public SupplierController(AppDBContext context)
        {
            _context = context;
        }

        // GET /api/quotation/{productname}/{quantity}
        [HttpGet("quotation/{productname}/{quantity}")]
        public IActionResult GetQuotation(string productname, int quantity)
        {
            // Query the product from the supplier's database
            var product = _context.Products.FirstOrDefault(p => p.ProductName == productname);
            if (product == null)
            {
                return NotFound("Product not found");
            }

            // Determine discount based on quantity
            decimal DiscountP;
            if (quantity >= 200)
            {
                DiscountP = 15; // 15% discount for 200 or more
            }
            else if (quantity >= 100)
            {
                DiscountP = 10; // 10% discount for 100-199
            }
            else
            {
                DiscountP = 5; // 5% discount for less than 100
            }

            // Calculate final price after discount
            var discountAmount = (product.Price * DiscountP / 100);
            var finalPrice = (product.Price - discountAmount) * quantity;

            // Return the product details
            var response = new
            {
                ProductName = product.ProductName,
                AvailableStock = product.AvailableStock,
                Price = product.Price,
                Discount = DiscountP,
                FinalPrice = finalPrice
            };

            return Ok(response);
        }

        // POST /api/order
        [HttpPost("order")]
        public IActionResult PlaceOrder([FromBody] OrderRequest orderRequest)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductName == orderRequest.ProductName);

            if (product == null || product.AvailableStock < orderRequest.Quantity)
            {
                return BadRequest("Insufficient stock or product not found");
            }

            // Determine discount based on quantity
            decimal DiscountP;
            if (orderRequest.Quantity >= 200)
            {
                DiscountP = 15; // 15% discount for 200 or more
            }
            else if (orderRequest.Quantity >= 100)
            {
                DiscountP = 10; // 10% discount for 100-199
            }
            else
            {
                DiscountP = 5; // 5% discount for less than 100
            }

            // Calculate final price after discount
            var discountAmount = (product.Price * DiscountP / 100);
            var totalprice = (product.Price - discountAmount) * orderRequest.Quantity;

            // Update stock after order
            product.AvailableStock -= orderRequest.Quantity;
            _context.SaveChanges();

            // Log the order
            var order = new Order
            {
                ProductName = product.ProductName,
                Quantity = orderRequest.Quantity,
                TotalPrice = totalprice,
                OrderDate = DateTime.Now
            };
            _context.Orders.Add(order);
            _context.SaveChanges();

            return Ok("Order placed successfully");
        }
    }
}
