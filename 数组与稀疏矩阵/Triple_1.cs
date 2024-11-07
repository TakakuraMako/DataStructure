using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public class Triple_1 : IComparable<Triple_1>
    {
        public int Row { get; }
        public int Col { get; }
        public Complex Value { get; set; }
        public Triple_1(int i, int j, Complex value)
        {
            if(i < 0 || j < 0)
                throw new Exception("数组元素位置无效.");
            Row = i;
            Col = j;
            Value = value;
        }
        public override string ToString()
        {
            return string.Format("({0},{1},{2})", Row, Col, Value);
        }
        public int CompareTo(Triple_1 other)
        {
            return Value.CompareTo(other.Value);
        }
    }
    public class SparseMatrix_1 : IMatrix<Complex>
    {
        private readonly DLinkList<Triple_1> _lst;
        public int Rows { get; }
        public int Cols { get; }
        public SparseMatrix_1(int rows, int cols)
        {
            if(rows <= 0 || cols <= 0)
                throw new ArgumentOutOfRangeException();
            Rows = rows;
            Cols = cols;
            _lst = new DLinkList<Triple_1>();
        }
        private DNode<Triple_1> GetIndex(int i, int j)
        {
            DNode<Triple_1> temp = _lst.PHead;
            while(temp != null)
            {
                if(temp.Data.Row == i && temp.Data.Col == j)
                    break;
                temp = temp.Next;
            }
            return temp;
        }
        private void RemoveNode(DNode<Triple_1> node)
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
        public Complex this[int i, int j]
        {
            get
            {
                if(i < 0 || i > Rows - 1 || j < 0 || j > Cols - 1)
                    throw new IndexOutOfRangeException();
                DNode<Triple_1> node = GetIndex(i, j);
                return node == null ? new Complex() : node.Data.Value;
            }
            set
            {
                if(i < 0 || i > Rows - 1 || j < 0 || j > Cols - 1)
                    throw new IndexOutOfRangeException();
                if(value == null)
                    throw new ArgumentNullException();
                DNode<Triple_1> node = GetIndex(i, j);
                if(node == null)
                {
                    if(value.A != 0 || value.B != 0)
                    {
                        _lst.InsertAtRear(new Triple_1(i, j, value));
                    }
                }
                else
                {
                    if(value.A != 0 && value.B != 0)
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
        public SparseMatrix_1 Add(SparseMatrix_1 b)
        {
            if(b == null)
                throw new ArgumentNullException();
            if(b.Rows != Rows || b.Cols != Cols)
                throw new Exception("两矩阵不能相加.");
            SparseMatrix_1 temp = new SparseMatrix_1(Rows, Cols);
            for(int i = 0; i < Rows; i++)
                for(int j = 0; j < Cols; j++)
                    temp[i, j] = this[i, j] + b[i, j];
            return temp;
        }
        public SparseMatrix_1 Transpose()
        {
            SparseMatrix_1 temp = new SparseMatrix_1(Cols, Rows);
            for(int i = 0; i < temp.Rows; i++)
                for(int j = 0; j < temp.Cols; j++)
                    temp[i, j] = this[j, i];
            return temp;
        }
        public SparseMatrix_1 Multiply(SparseMatrix_1 b)
        {
            if(b == null)
                throw new ArgumentNullException();
            if(Cols != b.Rows)
                throw new Exception("两矩阵不能相乘.");
            SparseMatrix_1 temp = new SparseMatrix_1(Rows, b.Cols);
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < b.Cols; j++)
                {
                    Complex value = new Complex();
                    for(int k = 0; k < Cols; k++)
                        value += this[i, k] * b[k, j];
                    temp[i, j] = value;
                }
            }
            return temp;
        }
        public static SparseMatrix_1 operator +(SparseMatrix_1 a, SparseMatrix_1 b)
        {
            if(a == null || b == null)
                throw new ArgumentNullException();
            return a.Add(b);
        }
        public static SparseMatrix_1 operator *(SparseMatrix_1 a, SparseMatrix_1 b)
        {
            if(a == null || b == null)
                throw new ArgumentNullException();
            return a.Multiply(b);
        }
        public override string ToString()
        {
            string str = string.Empty;
            DNode<Triple_1> temp = _lst.PHead;
            while(temp != null)
            {
                str += temp.Data + "\n";
                temp = temp.Next;
            }
            return str;
        }
        IMatrix<Complex> IMatrix<Complex>.Add(IMatrix<Complex> b)
        {
            return Add((SparseMatrix_1)b);
        }
        IMatrix<Complex> IMatrix<Complex>.Transpose()
        {
            return Transpose();
        }
        IMatrix<Complex> IMatrix<Complex>.Multiply(IMatrix<Complex> b)
        {
            return Multiply((SparseMatrix_1)b);
        }
    }

}
