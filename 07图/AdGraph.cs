using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    public class AdGraph
    {
        private readonly VertexNode[] _vertexList;
        public int VertexCount { get; }
        public AdGraph(int vCount)
        {
            if(vCount <= 0)
                throw new ArgumentOutOfRangeException();
            VertexCount = vCount;
            _vertexList = new VertexNode[vCount];
        }
        public string this[int index]
        {
            get
            {
                if(index < 0 || index > VertexCount - 1)
                    throw new ArgumentOutOfRangeException();
                return _vertexList[index] == null
                ? "NULL"
                : _vertexList[index].VertexName;
            }
            set
            {
                if(index < 0 || index > VertexCount - 1)
                    throw new ArgumentOutOfRangeException();
                if(_vertexList[index] == null)
                    _vertexList[index] = new VertexNode(value);
                else
                    _vertexList[index].VertexName = value;
            }
        }
        private int GetIndex(string vertexName)
        {
            int i;
            for(i = 0; i < VertexCount; i++)
            {
                if(_vertexList[i] != null && _vertexList[i].VertexName == vertexName)
                    break;
            }
            return i == VertexCount ? -1 : i;
        }
        public void AddEdge(string startVertexName, string endVertexName, double weight =
        0.0)
        {
            int i = GetIndex(startVertexName);
            int j = GetIndex(endVertexName);
            if(i == -1 || j == -1)
                throw new Exception("图中不存在该边.");
            EdgeNode temp = _vertexList[i].FirstNode;
            if(temp == null)
            {
                _vertexList[i].FirstNode = new EdgeNode(j, weight);
            }
            else
            {
                while(temp.Next != null)
                    temp = temp.Next;
                temp.Next = new EdgeNode(j, weight);
            }
        }
        private void Dfs(int i, ref string dfsResult)
        {
            //深度优先搜索递归函数
            _vertexList[i].Visited = true;
            dfsResult += _vertexList[i].VertexName + "\n";
            EdgeNode p = _vertexList[i].FirstNode;
            while(p != null)
            {
                if(_vertexList[p.Index].Visited)
                    p = p.Next;
                else
                    Dfs(p.Index, ref dfsResult);
            }
        }
        public string DfsTraversal(string startVertexName)
        {
            string dfsResult = string.Empty;
            int i = GetIndex(startVertexName);
            if(i != -1)
            {
                for(int j = 0; j < VertexCount; j++)
                    _vertexList[j].Visited = false;
                Dfs(i, ref dfsResult);
            }
            return dfsResult;
        }
        public string BfsTraversal(string startNodeName)
        {
            string bfsResult = string.Empty;
            int i = GetIndex(startNodeName);
            if(i != -1)
            {
                for(int j = 0; j < VertexCount; j++)
                    _vertexList[j].Visited = false;
                _vertexList[i].Visited = true;
                bfsResult += _vertexList[i].VertexName + "\n";
                LinkQueue<int> lq = new LinkQueue<int>();
                lq.EnQueue(i);
                while(lq.IsEmpty() == false)
                {
                    int j = lq.QueueFront;
                    lq.DeQueue();
                    EdgeNode p = _vertexList[j].FirstNode;
                    while(p != null)
                    {
                        if(_vertexList[p.Index].Visited == false)
                        {
                            _vertexList[p.Index].Visited = true;
                            bfsResult += _vertexList[p.Index].VertexName + "\n";
                            lq.EnQueue(p.Index);
                        }
                        p = p.Next;
                    }
                }
            }
            return bfsResult;
        }
        private int[] GetInDegressList()
        {
            int[] id = new int[VertexCount];
            for(int i = 0; i < VertexCount; i++)
            {
                EdgeNode p = _vertexList[i].FirstNode;
                while(p != null)
                {
                    id[p.Index]++;
                    p = p.Next;
                }
            }
            return id;
        }
        public string TopoSort()
        {
            string result = string.Empty;
            int[] id = GetInDegressList();
            LinkQueue<int> lq = new LinkQueue<int>();
            for(int i = 0; i < VertexCount; i++)
            {
                if(id[i] == 0)
                    lq.EnQueue(i);
            }
            if(lq.Length == VertexCount)
                throw new Exception("此有向图无有向边.");
            while(lq.IsEmpty() == false)
            {
                int j = lq.QueueFront;
                lq.DeQueue();
                result += _vertexList[j].VertexName + "\n";
                EdgeNode p = _vertexList[j].FirstNode;
                while(p != null)
                {
                    id[p.Index]--;
                    if(id[p.Index] == 0)
                    {
                        lq.EnQueue(p.Index);
                    }
                    p = p.Next;
                }
            }
            int k;
            for(k = 0; k < VertexCount; k++)
            {
                if(id[k] != 0)
                {
                    break;
                }
            }
            return (k == VertexCount) ? result : "该AOV网有环.";
        }
        public SpanTreeNode[] MiniSpanTree(string vName)
        {
            int i = GetIndex(vName);
            if(i == -1)
                return null;
            SpanTreeNode[] spanTree = new SpanTreeNode[VertexCount];
            spanTree[0] = new SpanTreeNode(_vertexList[i].VertexName, "NULL", 0.0);
            int[] vertexIndex = new int[VertexCount];
            double[] lowCost = new double[VertexCount];
            for(int j = 0; j < VertexCount; j++)
            {
                lowCost[j] = double.MaxValue;
                vertexIndex[j] = i;
            }
            EdgeNode p1 = _vertexList[i].FirstNode;
            while(p1 != null)
            {
                lowCost[p1.Index] = p1.Weight;
                p1 = p1.Next;
            }
            vertexIndex[i] = -1;
            for(int count = 1; count < VertexCount; count++)
            {
                double min = double.MaxValue;
                int v = i;
                for(int k = 0; k < VertexCount; k++)
                {
                    if(vertexIndex[k] != -1 && lowCost[k] < min)
                    {
                        min = lowCost[k];
                        v = k;
                    }
                }
                spanTree[count] = new SpanTreeNode(_vertexList[v].VertexName,
                _vertexList[vertexIndex[v]].VertexName, min);
                vertexIndex[v] = -1;
                EdgeNode p2 = _vertexList[v].FirstNode;
                while(p2 != null)
                {
                    if(vertexIndex[p2.Index] != -1 && p2.Weight < lowCost[p2.Index])
                    {
                        lowCost[p2.Index] = p2.Weight;
                        vertexIndex[p2.Index] = v;
                    }
                    p2 = p2.Next;
                }
            }
            return spanTree;
        }
        private Edge[] GetEdges()
        {
            for(int i = 0; i < VertexCount; i++)
                _vertexList[i].Visited = false;
            List<Edge> result = new List<Edge>();
            for(int i = 0; i < VertexCount; i++)
            {
                _vertexList[i].Visited = true;
                EdgeNode p = _vertexList[i].FirstNode;
                while(p != null)
                {
                    if(_vertexList[p.Index].Visited == false)
                    {
                        Edge edge = new Edge(i, p.Index, p.Weight);
                        result.Add(edge);
                    }
                    p = p.Next;
                }
            }
            return result.OrderBy(a => a.Weight).ToArray();
        }
        private int Find(int[] parent, int f)
        {
            while(parent[f] > -1)
                f = parent[f];
            return f;
        }
        public SpanTreeNode[] MiniSpanTree()
        {
            int[] parent = new int[VertexCount];
            for(int i = 0; i < VertexCount; i++)
            {
                parent[i] = -1;
            }
            SpanTreeNode[] tree = new SpanTreeNode[VertexCount];
            Edge[] edges = GetEdges();
            int count = 1;
            for(int i = 0; i < edges.Length; i++)
            {
                int begin = edges[i].Begin;
                int end = edges[i].End;
                int b = Find(parent, begin);
                int e = Find(parent, end);
                if(b != e)
                {
                    parent[e] = b;
                    tree[count] = new SpanTreeNode(_vertexList[end].VertexName,
                    _vertexList[begin].VertexName, edges[i].Weight);
                    count++;
                }
            }
            for(int i = 0; i < parent.Length; i++)
            {
                if(parent[i] == -1)
                {
                    tree[0] = new SpanTreeNode(_vertexList[i].VertexName, "NULL", 0.0);
                    break;
                }
            }
            return tree;
        }
        public string ShortestPath(string vName)
        {
            int v = GetIndex(vName);
            if(v == -1)
            {
                return string.Empty;
            }
            string result = string.Empty;
            double[] dist = new double[VertexCount];
            string[] path = new string[VertexCount];
            //初始化
            for(int i = 0; i < VertexCount; i++)
            {
                _vertexList[i].Visited = false;
                dist[i] = double.MaxValue;
                path[i] = _vertexList[v].VertexName;
            }
            dist[v] = 0.0;
            _vertexList[v].Visited = true;
            for(int i = 0; i < VertexCount - 1; i++)
            {
                EdgeNode p = _vertexList[v].FirstNode;
                while(p != null)
                {
                    if(_vertexList[p.Index].Visited == false
                    && dist[v] + p.Weight < dist[p.Index])
                    {
                        dist[p.Index] = dist[v] + p.Weight;
                        path[p.Index] = path[v] + " ->" + _vertexList[p.Index].VertexName;
                    }
                    p = p.Next;
                }
                double min = double.MaxValue;
                for(int j = 0; j < VertexCount; j++)
                {
                    if(_vertexList[j].Visited == false && dist[j] < min)
                    {
                        min = dist[j];
                        v = j;
                    }
                }
                _vertexList[v].Visited = true;
            }
            for(int i = 0; i < VertexCount; i++)
            {
                result += path[i] + ":" + dist[i] + "\n";
            }
            return result;
        }
        public string ConnectedComponent()
        {
            string result;
            SLinkList<string> lst = new SLinkList<string>();
            for(int i = 0; i < VertexCount; i++)
                _vertexList[i].Visited = false;
            for(int i = 0; i < VertexCount; i++)
            {
                if(_vertexList[i].Visited == false)
                {
                    result = string.Empty;
                    Dfs(i, ref result);
                    lst.InsertAtRear(result);
                }
            }
            result = string.Empty;
            for(int i = 0; i < lst.Length; i++)
            {
                result += "第" + i + "个连通分量为:\n" + lst[i];
            }
            return result;
        }

    }

}
