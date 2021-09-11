using ChurrasBeer.Domain.Entities.Base;
using ChurrasBeer.Infrastructure.CrossCutting.Enums;

namespace ChurrasBeer.Domain.Entities
{
    public class UserParty : Entity<string>
    {
        public EUserPerfil Perfil { get; private set; }
        public string UserId { get; private set; }
        public User User { get; private set; }
        public string PartyId { get; private set; }
        public Party Party { get; private set; }
    }
}
