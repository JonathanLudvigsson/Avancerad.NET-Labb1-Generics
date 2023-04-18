using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxSameVolume : IEqualityComparer<Box>
    {
        public bool Equals(Box x, Box y)
        {
            if (x.Height * x.Length * x.Width == y.Height * y.Length * y.Width)
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
