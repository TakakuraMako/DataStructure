using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03队列与多线程
{
    public class SeqQueue<T> : IQueue<T> where T : IComparable<T>
    {
        private readonly SeqList<T> _lst;
        public SeqQueue(int max)
        {
            if(max <= 0)
                throw new ArgumentOutOfRangeException();
            _lst = new SeqList<T>(max);
        }
        public int MaxSize
        {
            get { return _lst.MaxSize; }
        }
        public int Length
        {
            get { return _lst.Length; }
        }
        public T QueueFront
        {
            get
            {
                if(_lst.IsEmpty())
                    throw new Exception("队列为空,不能得到队首元素.");
                return _lst[0];
            }
        }
        public void EnQueue(T data)
        {
            if(_lst.Length == _lst.MaxSize)
                throw new Exception("队列已满,不能入队.");
            _lst.Insert(_lst.Length, data);
        }
        public void DeQueue()
        {
            if(_lst.IsEmpty())
                throw new Exception("队列为空,不能出队.");
            _lst.Remove(0);
        }
        public bool IsEmpty()
        {
            return _lst.IsEmpty();
        }
        public void Clear()
        {
            _lst.Clear();
        }
    }
}
