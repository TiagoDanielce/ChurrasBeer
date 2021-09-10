using ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Base;
using System;

namespace ChurrasBeer.Domain.Entities
{
    public class HourOption : Entity<string>
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public int Votes { get; private set; }
        public string LocationId { get; private set; }
        public Location Location { get; private set; }

    }
}
