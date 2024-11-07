using System;
using System.Collections.Generic;

namespace _02栈与递归
{
    class Program
    {
        static bool RailRoad(int[] p, int k)
        {
            LinkStack<int>[] h = new LinkStack<int>[k];
            for(int i = 0; i < k; i++)
            {
                h[i] = new LinkStack<int>();
            }

            int nowOut = 1; // 下一次要输出的车厢号
            int minH = int.MaxValue; // 缓冲铁轨中编号最小的车厢
            int minS = -1; // minH号车厢对应的缓冲铁轨

            foreach(int c in p)
            {
                if(c == nowOut)
                {
                    Console.WriteLine($"移动车厢：{c}从入轨到出轨。");
                    nowOut++;
                    while(minH == nowOut)
                    {
                        Output(ref minH, ref minS, h);
                        nowOut++;
                    }
                }
                else
                {
                    if(!Input(c, ref minH, ref minS, h))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static void Output(ref int minH, ref int minS, LinkStack<int>[] h)
        {
            h[minS].Pop();
            Console.WriteLine($"移动车厢：{minH}从缓冲轨{minS}到出轨。");

            minH = int.MaxValue;
            minS = -1;
            for(int i = 0; i < h.Length; i++)
            {
                if(h[i].Length > 0 && h[i].StackTop < minH)
                {
                    minH = h[i].StackTop;
                    minS = i;
                }
            }
        }

        static bool Input(int c, ref int minH, ref int minS, LinkStack<int>[] h)
        {
            int bestTrack = -1;
            int bestTop = int.MaxValue;

            for(int i = 0; i < h.Length; i++)
            {
                if(h[i].Length > 0)
                {
                    int x = h[i].StackTop;
                    if(c < x && x < bestTop)
                    {
                        bestTop = x;
                        bestTrack = i;
                    }
                }
                else if(bestTrack == -1)
                {
                    bestTrack = i;
                    break;
                }
            }

            if(bestTrack == -1)
                return false;

            h[bestTrack].Push(c);
            Console.WriteLine($"移动车厢：{c}从入轨到缓冲轨{bestTrack}。");

            if(c < minH)
            {
                minH = c;
                minS = bestTrack;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int[] p = new int[] { 3, 6, 9, 2, 4, 7, 1, 8, 5 };
            int k = 3;
            bool result = RailRoad(p, k);
            if(!result)
            {
                Console.WriteLine("需要更多的缓冲轨道。");
            }
            else
            {
                Console.WriteLine("车厢重排成功。");
            }
            Console.ReadKey();
        }
        
    }
}
