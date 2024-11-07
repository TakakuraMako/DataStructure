using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06树
{
    public class BinTreeNode<T> : IComparable<BinTreeNode<T>> where T : IComparable<T>
    {
        private T _data;
        public BinTreeNode<T> LeftChild { get; set; }
        public BinTreeNode<T> RightChild { get; set; }
        public T Data
        {
            get { return _data; }
            set
            {
                if(value == null)
                    throw new ArgumentNullException();
                _data = value;
            }
        }
        public BinTreeNode(T data, BinTreeNode<T> lChild = null, BinTreeNode<T> rChild =
        null)
        {
            if(data == null)
                throw new ArgumentNullException();
            LeftChild = lChild;
            _data = data;
            RightChild = rChild;
        }
        public int CompareTo(BinTreeNode<T> other)
        {
            if(other == null)
                throw new ArgumentNullException();
            return _data.CompareTo(other.Data);
        }
    }

}
