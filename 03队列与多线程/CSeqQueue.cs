using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03队列与多线程
{
    public class CSeqQueue<T> : IQueue<T> where T : IComparable<T>
    {
        private int _pFront;
        private int _pRear;
        private readonly T[] _dataset;
        public int Length { get; private set; }
        public int MaxSize { get; }
        public T QueueFront
        {
            get
            {
                if(Length == 0)
                    throw new Exception("队列为空不能得到队首元素.");
                return _dataset[_pFront];
            }
        }
        public CSeqQueue(int max)
        {
            if(max <= 0)
                throw new ArgumentOutOfRangeException();
            MaxSize = max;
            Length = 0;
            _dataset = new T[MaxSize];
            _pFront = 0;
            _pRear = 0;
        }
        public void EnQueue(T data)
        {
            if(Length == MaxSize)
                throw new Exception("队列已满,不能入队.");
            _dataset[_pRear] = data;
            _pRear = (_pRear + 1) % MaxSize;
            Length++;
        }
        public void DeQueue()
        {
            if(Length == 0)
                throw new Exception("队列为空,不能出队.");
            _pFront = (_pFront + 1) % MaxSize;
            Length--;
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
        public void Clear()
        {
            _pFront = 0;
            _pRear = 0;
            Length = 0;
        }
    }

}
