using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07图
{
    public class MGraph
    {
        private readonly double[,] _adMatrix;
        private readonly string[] _vertexNameList;
        public int VertexCount { get; }
        public MGraph(int vCount)
        {
            if(vCount <= 0)
                throw new ArgumentOutOfRangeException();
            VertexCount = vCount;
            _vertexNameList = new string[vCount];
            _adMatrix = new double[vCount, vCount];
        }
        public string this[int index]
        {
            get
            {
                if(index < 0 || index > VertexCount - 1)
                    throw new IndexOutOfRangeException();
                return _vertexNameList[index];
            }
            set
            {
                if(index < 0 || index > VertexCount - 1)
                    throw new IndexOutOfRangeException();
                _vertexNameList[index] = value;
            }
        }
        private int GetIndex(string vertexName)
        {
            int i;
            for(i = 0; i < VertexCount; i++)
            {
                if(_vertexNameList[i] == vertexName)
                    break;
            }
            return i == VertexCount ? -1 : i;
        }
        public void AddEdge(string startVertexName, string endVertexName, double weight =
        1)
        {
            int i = GetIndex(startVertexName);
            int j = GetIndex(endVertexName);
            if(i == -1 || j == -1)
                throw new Exception("图中不存在该边.");
            _adMatrix[i, j] = weight;
        }
    }
}
