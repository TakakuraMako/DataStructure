using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearList
{
    public class CLinkList<T> : ILinearList<T> where T : IComparable<T>
    {
        public SNode<T> PRear { get; private set; }
        public int Length { get; private set; }
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
        public CLinkList()
        {
            Length = 0;
            PRear = null;
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
        public void InsertAtRear(T data)
        {
            if(IsEmpty())
            {
                PRear = new SNode<T>(data);
                PRear.Next = PRear;
            }
            else
            {
                SNode<T> temp = new SNode<T>(data, PRear.Next);
                PRear.Next = temp;
                PRear = temp;
            }
            Length++;
        }
        public void InsertAtFirst(T data)
        {
            if(IsEmpty())
            {
                PRear = new SNode<T>(data);
                PRear.Next = PRear;
            }
            else
            {
                SNode<T> temp = new SNode<T>(data, PRear.Next);
                PRear.Next = temp;
            }
            Length++;
        }
        private SNode<T> Locate(int index)
        {
            if(index < 0 || index > Length - 1)
                throw new IndexOutOfRangeException();
            SNode<T> temp = PRear.Next;
            for(int i = 0; i < index; i++)
            {
                temp = temp.Next;
            }
            return temp;
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
            if(PRear == PRear.Next)
            {
                PRear = null;
            }
            else
            {
                if(index == Length - 1)
                {
                    SNode<T> temp = Locate(Length - 2);
                    temp.Next = PRear.Next;
                    PRear = temp;
                }
                else if(index == 0)
                {
                    PRear.Next = PRear.Next.Next;
                }
                else
                {
                    SNode<T> temp = Locate(index - 1);
                    temp.Next = temp.Next.Next;
                }
            }
            Length--;
        }
        public int Search(T data)
        {
            int i;
            SNode<T> temp = PRear;
            for(i = 0; i < Length; i++)
            {
                if(temp.Next.Data.CompareTo(data) == 0)
                    break;
                temp = temp.Next;
            }
            return (i == Length) ? -1 : i;
        }
        public void Clear()
        {
            Length = 0;
            PRear = null;
        }
    }
}
