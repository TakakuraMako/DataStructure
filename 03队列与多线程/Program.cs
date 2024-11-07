using System;
using System.Collections.Generic;
using System.Threading;

namespace _03队列与多线程
{
    public class BankQueue
    {
        private int callNumber = 0;
        private LinkQueue<int> queue = new LinkQueue<int>();

        public int GetCallNumber()
        {
            lock(queue)
            {
                callNumber++;
                return callNumber;
            }
        }

        public void Enqueue(int number)
        {
            lock(queue)
            {
                queue.EnQueue(number);
            }
        }

        public int Dequeue()
        {
            lock(queue)
            {
                if(queue.Length > 0)
                {
                    int number = queue.QueueFront;
                    queue.DeQueue();
                    return number;
                }
                return -1; // 返回-1表示队列为空
            }
        }

        public int Length
        {
            get
            {
                lock(queue)
                {
                    return queue.Length;
                }
            }
        }
    }

    public class ServiceWindow
    {
        private readonly BankQueue bankQueue;
        private readonly int windowNumber;

        public ServiceWindow(BankQueue bankQueue, int windowNumber)
        {
            this.bankQueue = bankQueue;
            this.windowNumber = windowNumber;
        }

        public void ServiceCustomers()
        {
            while(true)
            {
                int callNumber = bankQueue.Dequeue();
                if(callNumber != -1)
                {
                    Console.WriteLine("请{0}号到{1}号窗口办理业务！", callNumber, windowNumber);
                    Thread.Sleep(5000); // 模拟业务办理时间
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int windowCount = 3;
            BankQueue bankQueue = new BankQueue();
            List<Thread> serviceThreads = new List<Thread>();

            for(int i = 1; i <= windowCount; i++)
            {
                ServiceWindow serviceWindow = new ServiceWindow(bankQueue, i);
                Thread thread = new Thread(serviceWindow.ServiceCustomers);
                thread.Start();
                serviceThreads.Add(thread);
            }

            while(true)
            {
                Console.WriteLine("请点击触摸屏获取号码：");
                Console.ReadLine();
                int callNumber = bankQueue.GetCallNumber();
                Console.WriteLine("您的号码是：{0}，您前面有{1}位，请等待！", callNumber, bankQueue.Length);
                bankQueue.Enqueue(callNumber);
            }
        }
    }
}
