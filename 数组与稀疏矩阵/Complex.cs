using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public class Complex : IComparable
    {
        public int A { get; set; }
        public int B { get; set; }
        public Complex(int a = 0, int b = 0)
        {
            A = a;
            B = b;
        }
        public Complex Add(Complex C)
        {
            if(C == null)
                throw new ArgumentNullException();
            return new Complex(A + C.A, B + C.B);
        }
        public Complex Multiply(Complex C)
        {
            Complex temp = new Complex();
            temp.A = A * C.A - B * C.B;
            temp.B = A * C.B + B * C.A;
            return temp;
        }
        public static Complex operator +(Complex C1, Complex C2)
        {
            if(C1 == null || C2 == null)
                throw new ArgumentNullException();
            return C1.Add(C2);
        }
        public static Complex operator *(Complex C1, Complex C2)
        {
            if(C1 == null || C2 == null)
                throw new ArgumentNullException();
            return C1.Multiply(C2);
        }
        public int CompareTo(object obj)
        {
            Complex temp = obj as Complex;
            if(A == temp.A && B == temp.B)
                return 0;
            return -1;
        }
        public override string ToString()
        {
            return string.Format("{0}+{1}i", A, B);
        }
    }
}
