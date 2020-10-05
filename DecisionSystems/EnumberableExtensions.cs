using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecisionSystems
{
    public static class EnumberableExtensions
    {
        //so generisch, dass diese Funktion für sehr vieles genommen werden kann
        public static IEnumerable<TOut> PairWise<TIn, TOut>(this IEnumerable<TIn> items, Func<TIn, TIn, TOut> merge)
        {
            if (items is null)
            {
                throw new ArgumentNullException(nameof(items));
            }

            return items.Zip(items.Skip(1), merge);
        }
    }
}
