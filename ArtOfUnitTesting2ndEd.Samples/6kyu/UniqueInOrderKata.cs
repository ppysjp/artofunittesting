using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6kyu
{
    public class UniqueInOrderKata
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            var current = default(T);

            foreach (var item in iterable)
            {
                if (item.Equals(current))
                    continue;

                current = item;

                yield return item;
            }
        }

        public static IEnumerable<T> UniqueInOrder_NonRefactored<T>(IEnumerable<T> iterable)
        {
            var first = iterable.First();

            var uniques = new List<T>();

            uniques.Add(first);

            foreach (var item in iterable)
            {
                if (item.Equals(first)) // If this is the first time we have come across the item then skip the adding of the item.
                {
                    continue;
                }
                first = item; 
                uniques.Add(item);
            }

            return uniques;
        }


        public static IEnumerable<T> UniqueInOrder_DoesNotWorkButWouldHaveWorkedIfIhadKeptGoing<T>(IEnumerable<T> iterable)
        {
            var items = new List<T>();

            var uniqueItems = iterable.ToList().Distinct();

            foreach (var item in uniqueItems)
            {
                items.Add(item);
            }


            //return string.Join("", items);
            return items;
        }
    }
}
