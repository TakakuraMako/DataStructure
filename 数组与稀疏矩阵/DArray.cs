using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public class DArray<T> where T : IComparable<T>
    {
        private T[] _array;
        public int Size { get; private set; }
        public DArray(int size)
        {
            if(size <= 0)
                throw new ArgumentOutOfRangeException();
            Size = size;
            _array = new T[Size];
        }
        public void ReSize(int newSize)
        {
            if(newSize <= 0)
                throw new ArgumentOutOfRangeException();
            if(Size != newSize)
            {
                T[] newArray = new T[newSize];
                int n = newSize < Size ? newSize : Size;
                for(int i = 0; i < n; i++)
                {
                    newArray[i] = _array[i];
                }
                _array = newArray;
                Size = newSize;
            }
        }
        public T this[int index]
        {
            get
            {
                if(index < 0 || index > Size - 1)
                    throw new IndexOutOfRangeException();
                return _array[index];
            }
            set
            {
                if(index < 0 || index > Size - 1)
                    throw new IndexOutOfRangeException();
                _array[index] = value;
            }
        }
    }

}
