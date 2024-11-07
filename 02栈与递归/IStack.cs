using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02栈与递归
{
    public interface IStack<T> where T : IComparable<T>
    {
        int Length { get; }
        T StackTop { get; }
        void Push(T data);
        void Pop();
        bool IsEmpty();
        void Clear();
    }
}
