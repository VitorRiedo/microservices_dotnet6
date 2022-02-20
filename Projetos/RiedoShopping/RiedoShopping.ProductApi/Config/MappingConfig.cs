using AutoMapper;
using RiedoShopping.ProductApi.Data.ValueObjects;
using RiedoShopping.ProductApi.Model;

namespace RiedoShopping.ProductApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(Config =>
            {
                Config.CreateMap<ProductVO, Product>();
                Config.CreateMap<Product, ProductVO>();
            }); 

            return mappingConfig;
        }
    }
}
