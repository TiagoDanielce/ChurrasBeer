using ChurrasBeer.Infrastructure.CrossCutting.Enums;
using ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Base;

namespace ChurrasBeer.Domain.Entities
{
    public class Party : TrackableEntity<string, string>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public EPartyType Type { get; private set; }
        public EPartyStatus Status { get; private set; }
        public string Link { get; private set; }
    }
}
