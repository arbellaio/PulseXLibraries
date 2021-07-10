using System;
using System.Collections.Generic;
using System.Linq;

namespace PulseXLibraries.Extension.Linq
{
    public static class LinqExtensions
    {
        public static bool HasValue<T>(this IEnumerable<T> source)
        {
            if(source == null)
            {
                return false;
            }

            return source.Any();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return !source.HasValue();
        }
        
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
            (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}