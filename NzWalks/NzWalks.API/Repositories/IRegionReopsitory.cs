using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositories
{
    public interface IRegionReopsitory
    {
        Task<IEnumerable<Region>> GetAllRegionsAsync();
    }
}
