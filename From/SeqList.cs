using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _01线性表
{
    public class SeqList<T> : ILinearList<T> where T : IComparable<T>
    {
        protected readonly T[] Dataset;
        public int Length { get; private set; }
        public int MaxSize { get; }
        public SeqList(int max)
        {
            if(max < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            MaxSize = max;
            Length = 0;
            Dataset = new T[MaxSize];
        }
        public T this[int index]
        {
            get
            {
                if(index < 0 || index > Length - 1)
                    throw new IndexOutOfRangeException();
                return Dataset[index];
            }
            set
            {
                if(index < 0 || index > Length - 1)
                    throw new IndexOutOfRangeException();
                Dataset[index] = value;
            }
        }
        public bool IsEmpty()
        {
            if(Length == 0)
                return true;
            return false;
        }
        public void Insert(int index, T data)
        {
            if(index < 0 || index > Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(Length == MaxSize)
            {
                throw new Exception("达到最大值");
            }
            for(int i = Length; i - 1 >= index; i--)
            {
                Dataset[i] = Dataset[i-1];
            }
            Dataset[index] = data;
            Length++;
        }
        public void Remove(int index)
        {
            if(index < 0 || index > Length - 1)
            {
                throw new IndexOutOfRangeException();
            }
            for(int i = index; i < Length-1; i++)
            {
                Dataset[index] = Dataset[index + 1];
            }
            Length--;
        }
        public int Search(T data)
        {
            int i = 0;
            for(; i < Length; i++)
            {
                if(Dataset[i].CompareTo(data) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Clear()
        {
            Length = 0;
        }
    }
}
