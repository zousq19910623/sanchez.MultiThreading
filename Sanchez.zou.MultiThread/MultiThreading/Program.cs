using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //lesson 1
            //结果两组范围为1到10的数字会随机交叉输出。这说明
            //PrintNumbers方法同时运行在主线程和另一个线程中。
            //var t = new Thread(PrintNumbers);
            //t.Start();
            //PrintNumbers();

            //lesson 2
            //如何暂停线程而不消耗操作系统资源
            var t2 = new Thread(PrintNumbersWithDelay);
            t2.Start();
            PrintNumbers();
        }

        private static void PrintNumbers()
        {
            WriteLine("Starting ...");
            for (var i = 1; i < 10; i++)
            {
                WriteLine($"Starting--{i}");
            }
        }

        private static void PrintNumbersWithDelay()
        {
            WriteLine("Starting WithDelay ...");
            for (var i = 1; i < 10; i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine($"Starting WithDelay--{i}");
            }
        }
    }
}
