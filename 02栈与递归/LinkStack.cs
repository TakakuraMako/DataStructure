using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02栈与递归
{
    public class LinkStack<T> : IStack<T> where T : IComparable<T>
    {
        private readonly SLinkList<T> _lst;
        public LinkStack()
        {
            _lst = new SLinkList<T>();
        }
        public int Length
        {
            get { return _lst.Length; }
        }
        public T StackTop
        {
            get
            {
                if(_lst.Length == 0)
                    throw new Exception("栈为空.");
                return _lst[0];
            }
        }
        public void Push(T data)
        {
            _lst.InsertAtFirst(data);
        }
        public void Pop()
        {
            if(_lst.Length == 0)
                throw new Exception("栈为空.");
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
