using ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Base;

namespace ChurrasBeer.Domain.Entities
{
    public class User : TrackableEntity<string, string>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
