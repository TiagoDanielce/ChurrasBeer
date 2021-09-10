﻿using ChurrasBeer.Infrastructure.CrossCutting.Enums;
using ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Base;

namespace ChurrasBeer.Domain.Entities
{
    public class UserVote : Entity<string>
    {
        public EUserPerfil Perfil { get; private set; }
        public string UserId { get; private set; }
        public User User { get; private set; }
        public string HourOptionId { get; private set; }
        public HourOption HourOption { get; private set; }
    }
}
