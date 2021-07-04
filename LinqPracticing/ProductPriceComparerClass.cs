using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticing
{
    class ProductPriceComparerClass : EqualityComparer<Product>
    {
        public override bool Equals(Product x, Product y)
        {
            return (x.Price == y.Price); 
        }

        public override int GetHashCode([DisallowNull] Product obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
