using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public class SparseMatrix : IMatrix<double>
    {
        private readonly DLinkList<Triple> _lst;
        public int Rows { get; }
        public int Cols { get; }
        public SparseMatrix(int rows, int cols)
        {
            if(rows <= 0 || cols <= 0)
                throw new ArgumentOutOfRangeException();
            Rows = rows;
            Cols = cols;
            _lst = new DLinkList<Triple>();
        }
        private DNode<Triple> GetIndex(int i, int j)
        {
            DNode<Triple> temp = _lst.PHead;
            while(temp != null)
            {
                if(temp.Data.Row == i && temp.Data.Col == j)
                    break;
                temp = temp.Next;
            }
            return temp;
        }
        private void RemoveNode(DNode<Triple> node)
        {
            if(node.Next == null)
            {
                _lst.Remove(_lst.Length - 1);
            }
            else if(node.Prior == null)
            {
                _lst.Remove(0);
            }
            else
            {
                node.Prior.Next = node.Next;
                node.Next.Prior = node.Prior;
            }
        }
        public double this[int i, int j]
        {
            get
            {
                if(i < 0 || i > Rows - 1 || j < 0 || j > Cols - 1)
                    throw new IndexOutOfRangeException();
                DNode<Triple> node = GetIndex(i, j);
                return node == null ? 0.0 : node.Data.Value;
            }
            set
            {
                if(i < 0 || i > Rows - 1 || j < 0 || j > Cols - 1)
                    throw new IndexOutOfRangeException();
                DNode<Triple> node = GetIndex(i, j);
                if(node == null)
                {
                    if(value != 0.0)
                    {
                        _lst.InsertAtRear(new Triple(i, j, value));
                    }
                }
                else
                {
                    if(value != 0.0)
                    {
                        node.Data.Value = value;
                    }
                    else
                    {
                        RemoveNode(node);
                    }
                }
            }
        }
        public SparseMatrix Add(SparseMatrix b)
        {
            if(b == null)
                throw new ArgumentNullException();
            if(b.Rows != Rows || b.Cols != Cols)
                throw new Exception("两矩阵不能相加.");
            SparseMatrix temp = new SparseMatrix(Rows, Cols);
            for(int i = 0; i < Rows; i++)
                for(int j = 0; j < Cols; j++)
                    temp[i, j] = this[i, j] + b[i, j];
            return temp;
        }
        public SparseMatrix Transpose()
        {
            SparseMatrix temp = new SparseMatrix(Cols, Rows);
            for(int i = 0; i < temp.Rows; i++)
                for(int j = 0; j < temp.Cols; j++)
                    temp[i, j] = this[j, i];
            return temp;
        }
        public SparseMatrix Multiply(SparseMatrix b)
        {
            if(b == null)
                throw new ArgumentNullException();
            if(Cols != b.Rows)
                throw new Exception("两矩阵不能相乘.");
            SparseMatrix temp = new SparseMatrix(Rows, b.Cols);
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < b.Cols; j++)
                {
                    double value = 0.0;
                    for(int k = 0; k < Cols; k++)
                        value += this[i, k] * b[k, j];
                    temp[i, j] = value;
                }
            }
            return temp;
        }
        public static SparseMatrix operator +(SparseMatrix a, SparseMatrix b)
        {
            if(a == null || b == null)
                throw new ArgumentNullException();
            return a.Add(b);
        }
        public static SparseMatrix operator *(SparseMatrix a, SparseMatrix b)
        {
            if(a == null || b == null)
                throw new ArgumentNullException();
            return a.Multiply(b);
        }
        public override string ToString()
        {
            string str = string.Empty;
            DNode<Triple> temp = _lst.PHead;
            while(temp != null)
            {
                str += temp.Data + "\n";
                temp = temp.Next;
            }
            return str;
        }
        IMatrix<double> IMatrix<double>.Add(IMatrix<double> b)
        {
            return Add((SparseMatrix)b);
        }
        IMatrix<double> IMatrix<double>.Transpose()
        {
            return Transpose();
        }
        IMatrix<double> IMatrix<double>.Multiply(IMatrix<double> b)
        {
            return Multiply((SparseMatrix)b);
        }
    }

}
