using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    public class SpanTreeNode
    {
        public string SelfName { get; }
        public string ParentName { get; }
        public double Weight { get; set; }
        public SpanTreeNode(string selfName, string parentName, double weight)
        {
            if(string.IsNullOrEmpty(selfName) || string.IsNullOrEmpty(parentName))
                throw new ArgumentNullException();
            SelfName = selfName;
            ParentName = parentName;
            Weight = weight;
        }
    }

}
