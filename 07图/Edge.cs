using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    public class Edge
    {
        public int Begin { get; }
        public int End { get; }
        public double Weight { get; }
        public Edge(int begin, int end, double weight = 0.0)
        {
            Begin = begin;
            End = end;
            Weight = weight;
        }
    }

}
