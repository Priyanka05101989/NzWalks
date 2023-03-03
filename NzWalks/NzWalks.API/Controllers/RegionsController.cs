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

        [HttpGet]
        [Route("{name}")]
        public async Task<IActionResult> GetRegionById(string name)
        {
            var region = await _regionRepository.GetRegionByIdAsync(name);

            if(region == null)
            {
                return NotFound();
            }

            var regionDto = _mapper.Map<RegionDTO>(region);

            return Ok(regionDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(AddRegionDTO region)
        {

            var regionMode = _mapper.Map<Region>(region);

            var result = await _regionRepository.AddRegionAsyn(regionMode);

            return Ok(result);
        }
        
    }
}
