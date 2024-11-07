using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public interface IMatrix<T>
    {
        int Rows { get; }
        int Cols { get; }
        T this[int i, int j] { get; set; }
        IMatrix<T> Add(IMatrix<T> b);
        IMatrix<T> Transpose();
        IMatrix<T> Multiply(IMatrix<T> b);
    }
}
