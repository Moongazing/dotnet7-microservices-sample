using AutoMapper;
using TunahanAliOzturk.Services.CouponApi.Models;
using TunahanAliOzturk.Services.CouponApi.Models.Dto;

namespace TunahanAliOzturk.Services.CouponApi.Mapping
{
    public class MappingConfig:Profile
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>().ReverseMap();
            });

            return mappingConfig;
        }

    }
}
