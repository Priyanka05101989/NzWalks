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

        public async Task<Region> GetRegionByIdAsync(string Name)
        {
            return await _context.Regions.SingleOrDefaultAsync(r => r.Name == Name);
           

        }

        public async Task<Region> AddRegionAsyn(Region region)
        {
            region.Id = Guid.NewGuid();
            await _context.Regions.AddAsync(region);
            await _context.SaveChangesAsync();
            return region;

        }
    }
}
