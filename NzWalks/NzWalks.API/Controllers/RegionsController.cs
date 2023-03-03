using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NzWalks.API.Models.Domain;
using NzWalks.API.Models.DTO;
using NzWalks.API.Repositories;

namespace NzWalks.API.Controllers
{
    [ApiController]
    [Route("Regions")]
    public class RegionsController : Controller
    {
        private readonly IRegionReopsitory _regionRepository;
        private readonly IMapper _mapper;
        public RegionsController(IRegionReopsitory regionReopsitory, IMapper mapper)
        {
            this._regionRepository = regionReopsitory;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions() {

            var regions = await _regionRepository.GetAllRegionsAsync();

            var regionsDto = _mapper.Map<List<RegionDTO>>(regions);
           

            return Ok(regionsDto);
        
        
        }
        
    }
}
