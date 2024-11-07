using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05字符串与整数集合
{
    public interface IString
    {
        int Length { get; }
        char this[int index] { get; set; }
        IString Insert(int startIndex, IString s);
        IString Remove(int startIndex, int count);
        IString SubString(int startIndex, int count);
        IString Clone();
        IString Concat(IString s);
        int IndexOf(IString value, int startIndex = 0);
        IString PadLeft(int totalWidth, char paddingChar);
        IString Trim();
    }
}
