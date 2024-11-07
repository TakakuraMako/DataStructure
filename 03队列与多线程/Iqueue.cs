
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03队列与多线程
{
    public interface IQueue<T> where T : IComparable<T>
    {
        int Length { get; }
        T QueueFront { get; }
        void EnQueue(T data);
        void DeQueue();
        bool IsEmpty();
        void Clear();
    }
}
