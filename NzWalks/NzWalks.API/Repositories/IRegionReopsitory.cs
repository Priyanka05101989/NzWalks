using NzWalks.API.Models.Domain;

namespace NzWalks.API.Repositories
{
    public interface IRegionReopsitory
    {
        IEnumerable<Region> GetAllRegions();
    }
}
