using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05字符串与整数集合
{
    public class SeqString : IString
    {
        protected readonly char[] CStr;
        public SeqString()
        {
            CStr = new char[] { '\0' };
        }
        public SeqString(string s)
        {
            if(s == null)
                throw new ArgumentNullException();
            int len = s.Length;
            CStr = new char[len + 1];
            for(int i = 0; i < len; i++)
            {
                CStr[i] = s[i];
            }
            CStr[len] = '\0';
        }
        protected SeqString(int length)
        {
            if(length < 0)
                throw new ArgumentOutOfRangeException();
            CStr = new char[length + 1];
            CStr[length] = '\0';
        }
        public int Length
        {
            get
            {
                int i = 0;
                while(CStr[i] != '\0')
                    i++;
                return i;
            }
        }
        public char this[int index]
        {
            get
            {
                if(index < 0 || index > Length - 1)
                    throw new IndexOutOfRangeException();
                return CStr[index];
            }
            set
            {
                if(index < 0 || index > Length - 1)
                    throw new IndexOutOfRangeException();
                CStr[index] = value;
            }
        }
        public IString Insert(int startIndex, IString s)
        {
            if(s == null)
                throw new ArgumentNullException();
            if(startIndex < 0 || startIndex > Length)
                throw new ArgumentOutOfRangeException();
            int len1 = Length;
            int len2 = s.Length;
            SeqString str = new SeqString(len1 + len2);
            for(int i = 0; i < startIndex; i++)
            {
                str.CStr[i] = CStr[i];
            }
            for(int i = 0; i < len2; i++)
            {
                str.CStr[i + startIndex] = s[i];
            }
            for(int i = startIndex; i < len1; i++)
            {
                str.CStr[i + len2] = CStr[i];
            }
            return str;
        }
        public IString Concat(IString s)
        {
            if(s == null)
                throw new ArgumentNullException();
            return Insert(Length, s);
        }
        public static SeqString operator +(SeqString s1, SeqString s2)
        {
            if(s1 == null || s2 == null)
                throw new ArgumentNullException();
            return s1.Concat(s2) as SeqString;
        }
        public IString Remove(int startIndex, int count)
        {
            if(startIndex < 0 || startIndex > Length - 1)
                throw new ArgumentOutOfRangeException();
            if(count < 0)
                throw new ArgumentOutOfRangeException();
            int len = Length;
            int left = len - startIndex;
            count = (left < count) ? left : count;
            SeqString str = new SeqString(len - count);
            for(int i = 0; i < startIndex; i++)
            {
                str.CStr[i] = CStr[i];
            }
            for(int i = startIndex + count; i < len; i++)
            {
                str.CStr[i - count] = CStr[i];
            }
            return str;
        }
        public IString SubString(int startIndex, int count)
        {
            if(startIndex < 0 || startIndex > Length - 1)
                throw new ArgumentOutOfRangeException();
            if(count < 0)
                throw new ArgumentOutOfRangeException();
            int left = Length - startIndex;
            count = (left < count) ? left : count;
            SeqString str = new SeqString(count);
            for(int i = 0; i < count; i++)
                str.CStr[i] = CStr[i + startIndex];
            return str;
        }
        public IString Clone()
        {
            int len = Length;
            SeqString str = new SeqString(len);
            for(int i = 0; i < len; i++)
                str.CStr[i] = CStr[i];
            return str;
        }
        public IString PadLeft(int totalWidth, char paddingChar)
        {
            if(totalWidth < 0)
                throw new ArgumentOutOfRangeException();
            int len = Length;
            if(len >= totalWidth)
                return Clone();
            SeqString result = new SeqString(totalWidth);
            int left = totalWidth - len;
            for(int i = 0; i < left; i++)
            {
                result.CStr[i] = paddingChar;
            }
            for(int i = 0; i < len; i++)
            {
                result.CStr[i + left] = CStr[i];
            }
            return result;
        }
        public override string ToString()
        {
            string str = string.Empty;
            for(int i = 0, len = Length; i < len; i++)
                str += CStr[i];
            return str;
        }
        public int IndexOf(IString value, int startIndex = 0)
        {
            if(value == null || value.Length == 0)
                throw new Exception("匹配字符串为null或空.");
            if(startIndex < 0 || startIndex > value.Length - 1)
                throw new ArgumentOutOfRangeException();
            int len1 = Length;
            int len2 = value.Length;
            for(int i = startIndex; i <= len1 - len2; i++)
            {
                if(CStr[i] == value[0])
                {
                    int j;
                    for(j = 1; j < len2; j++)
                    {
                        if(CStr[j + i] != value[j])
                            break;
                    }
                    if(j == len2)
                        return i;
                }
            }
            return -1;
        }
        public IString Trim()
        {
            int left, right;
            int len = Length;
            for(left = 0; left < len; left++)
            {
                if(CStr[left] != ' ')
                    break;
            }
            if(left == len)
                return new SeqString();
            for(right = len - 1; right >= 0; right--)
            {
                if(CStr[right] != ' ')
                    break;
            }
            return SubString(left, right - left + 1);
        }
    }
}
