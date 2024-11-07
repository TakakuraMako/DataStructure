using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    public class VertexNode
    {
        public string VertexName { get; set; }
        public bool Visited { get; set; }
        public EdgeNode FirstNode { get; set; }
        public VertexNode(string vName, EdgeNode firstNode = null)
        {
            VertexName = vName;
            Visited = false;
            FirstNode = firstNode;
        }
    }
}
