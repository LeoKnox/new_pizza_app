using System;
using System.Collections;
using System.Collections.Generic;

namespace PizzaPlace070.Shared
{
    public static class IEnumerableExtensions
    {
        public static bool Any(this IEnumerable enumerable)
        => enumerable.GetEnumerator().MoveNext() == true;
    }
}