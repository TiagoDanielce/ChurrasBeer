using ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Interface;
using System;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Base
{
    public abstract class TrackableEntity<TKey, TUserKey> : Entity<TKey>, ITrackable<TUserKey>
    {
        public TUserKey InclusionUserId { get; protected set; }

        public DateTime InclusionDate { get; protected set; }

        public TUserKey UpdateUserId { get; protected set; }

        public DateTime UpdateDate { get; protected set; }

        public virtual void SetInclusionUserId(TUserKey inclusionUserId)
        {
            InclusionUserId = inclusionUserId;
            InclusionDate = DateTime.Now;

            if (UpdateUserIdIsEmptyOrDefault)
                SetUpdateUserId(inclusionUserId);
        }

        public void SetUpdateUserId(TUserKey updateUserId)
        {
            UpdateUserId = updateUserId;
            UpdateDate = DateTime.Now;
        }

        private bool UpdateUserIdIsEmptyOrDefault => UpdateUserId == null
            || string.IsNullOrEmpty(UpdateUserId.ToString())
            || UpdateUserId.Equals(default(TUserKey));
    }
}
