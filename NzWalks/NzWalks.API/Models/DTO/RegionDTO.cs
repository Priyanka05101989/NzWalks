using NzWalks.API.Models.Domain;

namespace NzWalks.API.Models.DTO
{
    public class RegionDTO
    {
        public Guid RegionID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double Area { get; set; }
        public List<Walk> Walks { get; set; }

    }
}
