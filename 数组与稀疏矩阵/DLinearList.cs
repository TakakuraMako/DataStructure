using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public class DNode<T> where T : IComparable<T>
    {
        public DNode<T> Prior { get; set; }
        public DNode<T> Next { get; set; }
        public T Data { get; set; }
        public DNode(T data, DNode<T> prior = null, DNode<T> next = null)
        {
            Prior = prior;
            Data = data;
            Next = next;
        }
    }

    public class DLinkList<T> : ILinearList<T> where T : IComparable<T>
    {
        public DNode<T> PHead { get; private set; }
        public DNode<T> PRear { get; private set; }
        public int Length { get; private set; }
        public DLinkList()
        {
            PHead = null;
            PRear = null;
            Length = 0;
        }
        public void InsertAtFirst(T data)
        {
            if(IsEmpty())
            {
                DNode<T> temp = new DNode<T>(data);
                PHead = temp;
                PRear = temp;
            }
            else
            {
                DNode<T> temp = new DNode<T>(data, null, PHead);
                PHead.Prior = temp;
                PHead = temp;
            }
            Length++;
        }
        public void InsertAtRear(T data)
        {
            if(IsEmpty())
            {
                DNode<T> temp = new DNode<T>(data);
                PHead = temp;
                PRear = temp;
            }
            else
            {
                DNode<T> temp = new DNode<T>(data, PRear, null);
                PRear.Next = temp;
                PRear = temp;
            }
            Length++;
        }
        private DNode<T> Locate(int index)
        {
            if(index < 0 || index > Length - 1)
                throw new IndexOutOfRangeException();
            DNode<T> temp = PHead;
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
                DNode<T> temp1 = Locate(index);
                DNode<T> temp2 = new DNode<T>(data, temp1.Prior, temp1);
                temp2.Prior.Next = temp2;
                temp2.Next.Prior = temp2;
                Length++;
            }
        }
        public void Remove(int index)
        {
            if(index < 0 || index > Length - 1)
                throw new IndexOutOfRangeException();
            if(Length == 1)
            {
                PHead = null;
                PRear = null;
            }
            else
            {
                if(index == 0)
                {
                    PHead = PHead.Next;
                    PHead.Prior = null;
                }
                else if(index == Length - 1)
                {
                    PRear = PRear.Prior;
                    PRear.Next = null;
                }
                else
                {
                    DNode<T> temp = Locate(index);
                    temp.Prior.Next = temp.Next;
                    temp.Next.Prior = temp.Prior;
                }
            }
            Length--;
        }
        public bool IsEmpty()
        {
            return Length == 0;
        }
        public void Clear()
        {
            Length = 0;
            PHead = null;
            PRear = null;
        }
        public int Search(T data)
        {
            int i;
            DNode<T> temp = PHead;
            for(i = 0; i < Length; i++)
            {
                if(temp.Data.CompareTo(data) == 0)
                    break;
                temp = temp.Next;
            }
            return i == Length ? -1 : i;
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
    }
}
