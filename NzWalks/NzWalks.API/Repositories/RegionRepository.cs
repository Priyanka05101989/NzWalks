using Microsoft.EntityFrameworkCore;
using NzWalks.API.Data;
using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositories
{
    public class RegionRepository : IRegionReopsitory
    {
        private readonly NzWalksDbContext _context;
        public RegionRepository(NzWalksDbContext context)
        {
            this._context = context;
        }
        public async Task<IEnumerable<Region>> GetAllRegionsAsync()
        {
            var regions = await _context.Regions.ToListAsync();

            return regions;
        }
    }
}
