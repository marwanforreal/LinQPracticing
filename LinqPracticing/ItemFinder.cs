using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticing
{
    public static class ItemFinder
    {
        public static IEnumerable<Product> ByItem(
            this IEnumerable<Product> query, string Item)
        {
            return query.Where(product => product.Name == Item);
        }
    }
}
