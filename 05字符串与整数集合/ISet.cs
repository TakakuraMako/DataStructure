
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05字符串与整数集合
{
    public interface ISet<T>
    {
        void Insert(T elt);
        void Remove(T elt);
        bool IsMember(T elt);
        string GetElements();
        ISet<T> Union(ISet<T> b);
        ISet<T> Intersect(ISet<T> b);
        ISet<T> DiffSet(ISet<T> b);
        ISet<T> Complement();
    }

}
