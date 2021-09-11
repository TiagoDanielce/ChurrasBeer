using System;

namespace ChurrasBeer.Domain.Interfaces.Entities
{
    public interface ITrackable<TUserKey>
    {
        TUserKey InclusionUserId { get; }
        
        DateTime InclusionDate { get; }
        
        TUserKey UpdateUserId { get; }
        
        DateTime UpdateDate { get; }

        void SetInclusionUserId(TUserKey inclusionUserId);

        void SetUpdateUserId(TUserKey updateUserId);
    }
}
