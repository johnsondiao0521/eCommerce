using AutoMapper;

namespace eCommerce.WebService
{
    public class MappingConfig
    {
        public static void RegisterMapping()
        {
            Mapper.AddProfile(new ApplicationLayer.Map());
        }
    }
}