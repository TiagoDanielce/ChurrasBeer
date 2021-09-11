using System;
using System.Linq;
using System.Linq.Expressions;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.IQueryables
{
    public static class IQueryableExtension
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, bool condition)
        {
            if (condition)
                return source.Where(predicate);

            return source;
        }
    }
}
