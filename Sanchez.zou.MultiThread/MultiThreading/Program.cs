using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MultiThreading.Lesson_1;
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
            //var t=new Thread(ThreadDemo.PrintNumbers);
            //t.Start();
            //ThreadDemo.PrintNumbers();

            //lesson 2
            //如何暂停线程而不消耗操作系统资源，使用Sleep
            //var t2 = new Thread(ThreadDemo.PrintNumbersWithDelay);
            //t2.Start();
            //ThreadDemo.PrintNumbers();

            //lesson 3
            //如何让程序等待另一个线程中的计算完成，使用Join
            //可以实现在两个线程间同步执行步骤
            //WriteLine("Starting ...");
            //var t3 = new Thread(ThreadDemo.PrintNumbersWithDelay);
            //t3.Start();
            //t3.Join();
            //WriteLine("Thread Completed");

            //lesson 4
            //使用abort技术不一定总能终止线程。
            //目标线程可以通过处理该异常并调用Thread.ResetAbort方法来拒绝被终止。
            //因此并不推荐使用Abort方法来关闭线程。
            WriteLine("Starting programing...");
            var t4 = new Thread(ThreadDemo.PrintNumbersWithDelay);
            t4.Start();
            Sleep(TimeSpan.FromSeconds(6));
            t4.Abort();
            WriteLine("A Thread has been aborted");
            var t41 = new Thread(ThreadDemo.PrintNumbers);
            t41.Start();
            ThreadDemo.PrintNumbers();
        }
    }
}
