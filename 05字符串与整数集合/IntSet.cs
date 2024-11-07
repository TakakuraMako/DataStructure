using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05字符串与整数集合
{
    public class IntSet : ISet<uint>
    {
        private readonly uint[] _bitSet;
        public uint MaxRange { get; }
        public IntSet(uint maxRge)
        {
            MaxRange = maxRge;
            _bitSet = new uint[MaxRange / 32 + 1];
            for(int i = 0; i < _bitSet.Length; i++)
            {
                _bitSet[i] = 0;
            }
        }
        private uint ArrayIndex(uint elt)
        {
            if(elt > MaxRange)
                throw new ArgumentOutOfRangeException();
            return elt / 32;
        }
        private uint BitMask(uint elt)
        {
            if(elt > MaxRange)
                throw new ArgumentOutOfRangeException();
            return (uint)Math.Pow(2, elt % 32);
        }
        public void Insert(uint elt)
        {
            if(elt > MaxRange)
                throw new ArgumentOutOfRangeException();
            _bitSet[ArrayIndex(elt)] |= BitMask(elt);
        }
        public void Remove(uint elt)
        {
            if(elt > MaxRange)
                throw new ArgumentOutOfRangeException();
            _bitSet[ArrayIndex(elt)] &= ~BitMask(elt);
        }
        public bool IsMember(uint elt)
        {
            if(elt > MaxRange)
                return false;
            uint i = _bitSet[ArrayIndex(elt)] & BitMask(elt);
            return i != 0;
        }
        public string GetBitString()
        {
            string temp = string.Empty;
            for(int i = 0; i < _bitSet.Length; i++)
            {
                temp = Convert.ToString(_bitSet[i], 2).PadLeft(32, '0') + temp;
            }
            return temp.Remove(0, 32 - (int)(MaxRange % 32 + 1));
        }
        public string GetElements()
        {
            string s = GetBitString();
            string temp = string.Empty;
            int j = 0;
            for(int i = s.Length - 1; i >= 0; i--)
{
                if(s[i] == '1')
                    temp += j + " ";
                j++;
            }
            return temp.Trim();
        }
        public IntSet Union(IntSet b)
        {
            if(b == null)
                throw new ArgumentNullException();
            if(b.MaxRange != MaxRange)
                throw new Exception("两个集合范围不同.");
            IntSet temp = new IntSet(MaxRange);
            for(int i = 0; i < _bitSet.Length; i++)
            {
                temp._bitSet[i] = _bitSet[i] | b._bitSet[i];
            }
            return temp;
        }
        public IntSet Intersect(IntSet b)
        {
            if(b == null)
                throw new ArgumentNullException();
            if(MaxRange != b.MaxRange)
                throw new Exception("两个集合范围不同.");
            IntSet temp = new IntSet(MaxRange);
            for(int i = 0; i < _bitSet.Length; i++)
            {
                temp._bitSet[i] = _bitSet[i] & b._bitSet[i];
            }
            return temp;
        }
        public IntSet DiffSet(IntSet b)
        {
            if(b == null)
                throw new ArgumentNullException();
            if(MaxRange != b.MaxRange)
                throw new Exception("两集合范围不同.");
            IntSet temp = new IntSet(MaxRange);
            for(int i = 0; i < _bitSet.Length; i++)
            {
                temp._bitSet[i] = _bitSet[i] & (~b._bitSet[i]);
            }
            return temp;
        }
        public IntSet Complement()
        {
            IntSet temp = new IntSet(MaxRange);
            for(int i = 0; i < _bitSet.Length; i++)
            {
                temp._bitSet[i] = ~_bitSet[i];
            }
            return temp;
        }
        ISet<uint> ISet<uint>.Union(ISet<uint> b)
        {
            return Union(b as IntSet);
        }
        ISet<uint> ISet<uint>.Intersect(ISet<uint> b)
        {
            return Intersect(b as IntSet);
        }
        ISet<uint> ISet<uint>.DiffSet(ISet<uint> b)
        {
            return DiffSet(b as IntSet);
        }
        ISet<uint> ISet<uint>.Complement()
        {
            return Complement();
        }
    }

}
