using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection boxCol;
        private int currentIndex;
        private Box currentBox;

        public BoxEnumerator(BoxCollection boxcol)
        {
            boxCol = boxcol;
            currentIndex = -1;
            currentBox = default(Box);
        }

        public Box Current { get { return currentBox; } }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            currentIndex++;
            if(currentIndex >= boxCol.Count)
            {
                return false;
            }
            else
            {
                currentBox = boxCol[currentIndex];
                return true;
            }
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
