using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    /*public class SNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public SNode<T> Next {  get; set; }
        public SNode(T data, SNode<T> next = null)
        {
            Data = data;
            Next = next;
        }
    }*/

    public class SLinkList<T> : ILinearList<T> where T : IComparable<T>
    {
        public SNode<T> PHead { get; private set; }
        public int Length { get; private set; }
        public SLinkList()
        {
            Length = 0;
            PHead = null;
        }
        public void InsertAtFirst(T data)
        {
            PHead = new SNode<T>(data, PHead);
            Length++;
        }
        private SNode<T> Locate(int index)
        {
            if(index < 0 || index > Length - 1)
                throw new IndexOutOfRangeException();
            SNode<T> temp = PHead;
            for(int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
        }
        public void InsertAtRear(T data)
        {
            if(PHead == null)
            {
                PHead = new SNode<T>(data);
            }
            else
            {
                Locate(Length - 1).Next = new SNode<T>(data);
            }
            Length++;
        }
        public T this[int index]
        {
            get
            {
                if(index < 0 || index > Length - 1)
                    throw new IndexOutOfRangeException();
                return Locate(index).Data;
            }
            set
            {
                if(index < 0 || index > Length - 1)
                    throw new IndexOutOfRangeException();
                Locate(index).Data = value;
            }
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
        public void Insert(int index, T data)
        {
            if(index < 0 || index > Length)
                throw new IndexOutOfRangeException();
            if(index == 0)
            {
                InsertAtFirst(data);
            }
            else if(index == Length)
            {
                InsertAtRear(data);
            }
            else
            {
                SNode<T> temp = Locate(index - 1);
                temp.Next = new SNode<T>(data, temp.Next);
                Length++;
            }
        }
        public void Remove(int index)
        {
            if(index < 0 || index > Length - 1)
                throw new IndexOutOfRangeException();
            if(index == 0)
            {
                PHead = PHead.Next;
            }
            else
            {
                SNode<T> temp = Locate(index - 1);
                temp.Next = temp.Next.Next;
            }
            Length--;
        }
        public int Search(T data)
        {
            int i;
            SNode<T> temp = PHead;
            for(i = 0; i < Length; i++)
            {
                if(temp.Data.CompareTo(data) == 0)
                    break;
                temp = temp.Next;
            }
            return i == Length ? -1 : i;
        }
        public void Clear()
        {
            PHead = null;
            Length = 0;
        }
    }
}
