using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositories
{
    public interface IRegionReopsitory
    {
        Task<List<Region>> GetAllRegionsAsync();

        Task<Region> GetRegionByIdAsync(string Name);

        Task<Region> AddRegionAsyn(Region region);
    }
}
