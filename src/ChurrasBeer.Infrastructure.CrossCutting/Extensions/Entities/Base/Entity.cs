using System;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.Entities.Base
{
    public abstract class Entity<TKey>
    {
        public TKey Id { get; protected set; }

        public Entity()
        {
            if (typeof(TKey).IsAssignableFrom(typeof(string)) && Id is not null)
                SetId();
        }

        private void SetId()
        {
            string guid = Guid.NewGuid().ToString();
            Id = (TKey)Convert.ChangeType(guid, typeof(TKey));
        }
    }
}
