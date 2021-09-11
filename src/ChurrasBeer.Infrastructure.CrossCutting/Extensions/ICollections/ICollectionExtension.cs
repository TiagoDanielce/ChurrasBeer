using System.Collections.Generic;
using System.Linq;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.ICollections
{
    public static class ICollectionExtension
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
        {
            return collection == null || !collection.Any();
        }
    }
}
