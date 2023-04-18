using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxSameDimensions : IEqualityComparer<Box>
    {
        public bool Equals(Box x, Box y)
        {
            if (x.Height == y.Height && x.Length == y.Length && x.Width == y.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode([DisallowNull] Box obj)
        {
            var hcode = obj.Height ^ obj.Length ^ obj.Width;
            return hcode.GetHashCode();
        }
    }
}
