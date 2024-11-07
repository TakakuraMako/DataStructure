using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    public class EdgeNode
    {
        public int Index { get; }
        public double Weight { get; }
        public EdgeNode Next { get; set; }
        public EdgeNode(int index, double weight = 0.0, EdgeNode next = null)
        {
            if(index < 0)
                throw new ArgumentOutOfRangeException();
            Index = index;
            Weight = weight;
            Next = next;
        }
    }

}
