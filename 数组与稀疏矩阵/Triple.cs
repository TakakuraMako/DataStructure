using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组与稀疏矩阵
{
    public class Triple : IComparable<Triple>
    {
        public int Row { get; }
        public int Col { get; }
        public double Value { get; set; }
        public Triple(int i, int j, double value)
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
        public int CompareTo(Triple other)
        {
            if(Value < other.Value) return -1;
            if(Value > other.Value) return 1;
            return 0;
        }
    }
}
