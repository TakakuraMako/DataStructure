using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public interface ILinearList<T> where T : IComparable<T>
    {
        int Length { get; }
        T this[int index] { get; set; }
        bool IsEmpty();
        void Insert(int index, T data);
        void Remove(int index);
        int Search(T data);
        void Clear();
    }
}
