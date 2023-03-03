using AutoMapper;
using Microsoft.Extensions.Options;
using NzWalks.API.Models.Domain;
using NzWalks.API.Models.DTO;

namespace NzWalks.API.Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<Region, RegionDTO>()
                                           .ForMember(dest => dest.RegionID, Options => Options.MapFrom(src => src.Id));
            CreateMap<AddRegionDTO, Region>();
        }

    }
}
