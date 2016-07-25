

using System;
using System.Collections.Generic;

namespace F1sh.Core
{
    public static class Extensions
    {
        public static bool IsNullOrDefault<T>(this T? value) where T : struct
        {
            return default(T).Equals(value.GetValueOrDefault());
        }


        /// <summary>
        /// Indicates whether the specified System.Collections.Generic.IEnumerable&lt;T&gt; is null or empty
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">This instance of System.Collections.Generic.IEnumerable&lt;T&gt;.</param>
        /// <returns>true if the System.Collections.Generic.IEnumerable&lt;T&gt; is null or empty; otherwise, false.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.FastAny();
        }

        /// <summary>
        /// <para>Enumerable.Any<T> doesn't cast to ICollection, like it does with many of the other LINQ methods.</para>
        /// <para>This method is significantly faster (4x) when mainly working with ICollection sources and a little</para>
        /// <para>slower if working with mainly IEnumerable<T> sources.</para>
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source">This instance of System.Collections.Generic.IEnumerable&lt;TSource&gt;.</param>
        /// <returns>true if the System.Collections.Generic.IEnumerable&lt;TSource&gt; is empty; otherwise, false.</returns>
        public static bool FastAny<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            var collection = source as ICollection<TSource>;

            if (collection != null)
            {
                return collection.Count > 0;
            }

            var array = source as TSource[];

            if (array != null)
            {
                return array.Length > 0;
            }

            using (var enumerator = source.GetEnumerator())
            {
                return enumerator.MoveNext();
            }
        }
    }
}
