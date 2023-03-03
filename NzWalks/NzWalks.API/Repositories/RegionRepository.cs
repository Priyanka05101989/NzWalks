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
        public IEnumerable<Region> GetAllRegions()
        {
            var regions = _context.Regions.ToList();

            return regions;
        }
    }
}
