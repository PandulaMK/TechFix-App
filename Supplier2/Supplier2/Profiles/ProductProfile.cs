using AutoMapper;
using Supplier2.DTO;
using Supplier2.Model;

namespace Supplier2.Profiles
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
