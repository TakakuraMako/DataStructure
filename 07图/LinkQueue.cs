using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    public class LinkQueue<T> : IQueue<T> where T : IComparable<T>
    {
        private readonly CLinkList<T> _lst;
        public int Length
        {
            get { return _lst.Length; }
        }
        public T QueueFront
        {
            get
            {
                if(_lst.IsEmpty())
                    throw new Exception("队列为空,不能取队首元素.");
                return _lst[0];
            }
        }
        public LinkQueue()
        {
            _lst = new CLinkList<T>();
        }
        public void EnQueue(T data)
        {
            _lst.InsertAtRear(data);
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
