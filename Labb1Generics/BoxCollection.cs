using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Labb1Generics
{
    internal class BoxCollection : ICollection<Box>
    {
        public List<Box> boxList;

        public BoxCollection()
        {
            boxList = new List<Box>();
        }

        public Box this[int index]
        {
            get { return boxList[index]; }
            set { boxList[index] = value; }
        }

        public void PrintBoxes()
        {
            int i = 0;
            foreach (Box b in boxList)
            {
                i++;
                Console.WriteLine($"#{i} - Heigth={b.Height} Length={b.Length} Width={b.Width}");
            }
        }

        public int Count
        {
            get { return boxList.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(Box item)
        {
            if (!boxList.Contains(item))
            {
                boxList.Add(item);
            }
            else
            {
                Console.WriteLine($"A box with those dimensions already exists");
            }
        }

        public void Clear()
        {
            boxList.Clear();
        }

        public bool Contains(Box item)
        {
            foreach (Box b in boxList)
            {
                if (b.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(Box item, EqualityComparer<Box> sameVol)
        {
            foreach (Box b in boxList)
            {
                if (sameVol.Equals(b, item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The Array cannot be null");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index can not be negative");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection");
            }
            for (int i = 0; i < boxList.Count; i++)
            {
                array[i + arrayIndex] = boxList[i];
            }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            int index = IndexOf(item);
            if (index >= 0 && index < boxList.Count)
            {
                RemoveAt(index);
                Console.WriteLine("REMOVING BOX");
                return true;
            }
            return false;
        }

        private void RemoveAt(int index)
        {
            boxList.RemoveAt(index);
        }

        private int IndexOf(Box item)
        {
            int index = 0;
            foreach (Box b in boxList)
            {
                if (b.Equals(item)){
                    return index;
                }
                index++;
            }
            return -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }
    }
}
