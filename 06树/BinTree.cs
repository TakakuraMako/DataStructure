using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06树
{
    public class BinTree<T> where T : IComparable<T>
    {
        private string _orderString = string.Empty;
        public BinTreeNode<T> Root { get; set; }
        public BinTree(BinTreeNode<T> root)
        {
            Root = root;
        }
        public void Insert(BinTreeNode<T> current, BinTreeNode<T> lChild, BinTreeNode<T>
        rChild)
        {
            if(Root == null)
                throw new Exception("树为空.");
            if(current == null)
                throw new ArgumentNullException();
            current.LeftChild = lChild;
            current.RightChild = rChild;
        }
        private void PreOrder(BinTreeNode<T> current)
        {
            if(current == null)
                return;
            _orderString += current.Data + " ";
            PreOrder(current.LeftChild);
            PreOrder(current.RightChild);
        }
        public string PreOrderTraversal()
        {
            _orderString = string.Empty;
            PreOrder(Root);
            return _orderString.Trim();
        }
        private void MidOrder(BinTreeNode<T> current)
        {
            if(current == null)
                return;
            MidOrder(current.LeftChild);
            _orderString += current.Data + " ";
            MidOrder(current.RightChild);
        }
        public string MidOrderTraversal()
        {
            _orderString = string.Empty;
            MidOrder(Root);
            return _orderString.Trim();
        }
        private void PostOrder(BinTreeNode<T> current)
        {
            if(current == null)
                return;
            PostOrder(current.LeftChild);
            PostOrder(current.RightChild);
            _orderString += current.Data + " ";
        }
        public string PostOrderTraversal()
        {
            _orderString = string.Empty;
            PostOrder(Root);
            return _orderString.Trim();
        }
        public string LevelTraversal()
        {
            _orderString = string.Empty;
            if(Root != null)
            {
                LinkQueue<BinTreeNode<T>> lq = new LinkQueue<BinTreeNode<T>>();
                lq.EnQueue(Root);
                while(lq.IsEmpty() == false)
                {
                    BinTreeNode<T> temp = lq.QueueFront;
                    lq.DeQueue();
                    _orderString += temp.Data + " ";
                    if(temp.LeftChild != null)
                        lq.EnQueue(temp.LeftChild);
                    if(temp.RightChild != null)
                        lq.EnQueue(temp.RightChild);
                }
            }
            return _orderString.Trim();
        }
        private BinTreeNode<T> FindParent(BinTreeNode<T> current, BinTreeNode<T> find)
        {
            if(find == null)
                throw new ArgumentNullException();
            if(current == null)
                return null;
            if(current.LeftChild != null && current.LeftChild.Equals(find))
                return current;
            if(current.RightChild != null && current.RightChild.Equals(find))
                return current;
            BinTreeNode<T> temp = FindParent(current.LeftChild, find);
            if(temp != null)
                return temp;
            return FindParent(current.RightChild, find);
        }
        public BinTreeNode<T> GetParent(BinTreeNode<T> find)
        {
            if(find == null)
                throw new ArgumentNullException();
            return FindParent(Root, find);
        }
        public BinTreeNode<T> GetLeftSibling(BinTreeNode<T> current)
        {
            if(current == null)
                throw new ArgumentNullException();
            BinTreeNode<T> parent = GetParent(current);
            if(parent != null && parent.LeftChild != null &&
            parent.LeftChild.Equals(current) == false)
                return parent.LeftChild;
            return null;
        }
        public BinTreeNode<T> GetRightSibling(BinTreeNode<T> current)
        {
            if(current == null)
                throw new ArgumentNullException();
            BinTreeNode<T> parent = GetParent(current);
            if(parent != null && parent.RightChild != null &&
            parent.RightChild.Equals(current) == false)
                return parent.RightChild;
            return null;
        }
        public void DeleteSubTree(BinTreeNode<T> current)
        {
            if(current == null)
                throw new ArgumentNullException();
            if(Root == null)
                throw new Exception("二叉树为null.");
            if(Root.Equals(current))
            {
                Root = null;
            }
            else
            {
                BinTreeNode<T> parent = GetParent(current);
                if(parent != null && parent.LeftChild != null &&
                parent.LeftChild.Equals(current))
                    parent.LeftChild = null;
                if(parent != null && parent.RightChild != null &&
                parent.RightChild.Equals(current))
                    parent.RightChild = null;
            }
        }
        private BinTreeNode<T> FindData(BinTreeNode<T> current, T data)
        {
            if(data == null)
                throw new ArgumentNullException();
            if(current == null)
                return null;
            if(current.Data.CompareTo(data) == 0)
                return current;
            BinTreeNode<T> temp = FindData(current.LeftChild, data);
            if(temp != null)
                return temp;
            return FindData(current.RightChild, data);
        }
        public BinTreeNode<T> Search(T data)
        {
            if(data == null)
                throw new ArgumentNullException();
            return FindData(Root, data);
        }
        private void FindLeafCount(BinTreeNode<T> current, ref int count)
        {
            if(current == null)
                return;
            if(current.LeftChild == null && current.RightChild == null)
            {
                count++;
                return;
            }
            FindLeafCount(current.LeftChild, ref count);
            FindLeafCount(current.RightChild, ref count);
        }
        public int GetLeafCount()
        {
            int count = 0;
            FindLeafCount(Root, ref count);
            return count;
        }
        private void Exchange(BinTreeNode<T> current)
        {
            if(current == null)
                return;
            if(current.LeftChild != null || current.RightChild != null)
            {
                BinTreeNode<T> temp = current.LeftChild;
                current.LeftChild = current.RightChild;
                current.RightChild = temp;
            }
            if(current.LeftChild != null)
                Exchange(current.LeftChild);
            if(current.RightChild != null)
                Exchange(current.RightChild);
        }
        public void Exchange()
        {
            Exchange(Root);
        }
    }

}
