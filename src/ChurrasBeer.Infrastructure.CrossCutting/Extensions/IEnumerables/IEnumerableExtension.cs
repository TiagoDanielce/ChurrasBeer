using System;
using System.Collections.Generic;
using System.Linq;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.IEnumerables
{
    public static class IEnumerableExtension
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }

        public static IEnumerable<List<T>> Split<T>(this IEnumerable<T> enumerable, int nSize)
        {
            var list = enumerable.ToList();

            for (int i = 0; i < list.Count; i += nSize)
            {
                yield return list.GetRange(i, Math.Min(nSize, list.Count - i));
            }
        }

        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate, bool condition)
        {
            if (condition)
                return source.Where(predicate);

            return source;
        }
    }
}
