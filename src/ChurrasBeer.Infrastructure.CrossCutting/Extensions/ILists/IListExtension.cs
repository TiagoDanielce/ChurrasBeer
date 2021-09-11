using System;
using System.Collections.Generic;

namespace ChurrasBeer.Infrastructure.CrossCutting.Extensions.ILists
{
    public static class IListExtension
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int random = rng.Next(count + 1);
                T value = list[random];
                list[random] = list[count];
                list[count] = value;
            }
        }
    }
}
