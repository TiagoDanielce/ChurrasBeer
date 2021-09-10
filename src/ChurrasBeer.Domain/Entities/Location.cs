using ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Base;

namespace ChurrasBeer.Domain.Entities
{
    public class Location : Entity<string>
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }
        public string PartyId { get; private set; }
        public Party Party { get; private set; }
    }
}
