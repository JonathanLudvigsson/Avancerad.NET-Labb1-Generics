using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    public class Box : IEquatable<Box>
    {
        //public int ID { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public static int IDCount = 0;

        public Box(int height, int length, int width)
        {
            //IDCount++;
            //ID = IDCount;
            Height = height;
            Length = length;
            Width = width;
        }

        public bool Equals(Box other)
        {
            if (new BoxSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}