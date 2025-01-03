using AutoMapper;
using Supplier1.DTO;
using Supplier1.Model;

namespace Supplier1.Profiles
{
    public class ProductProfile: Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, DTOReadProduct>();
            CreateMap<DTOCreateProduct, Product>();
        }
    }
}
