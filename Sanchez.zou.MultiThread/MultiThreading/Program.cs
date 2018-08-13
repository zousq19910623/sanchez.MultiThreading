using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MultiThreading.Lesson_1;
using static System.Console;
using static System.Threading.Thread;
using static System.Diagnostics.Process;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            //lesson 1
            //结果两组范围为1到10的数字会随机交叉输出。这说明
            //PrintNumbers方法同时运行在主线程和另一个线程中。
            //var t = new Thread(ThreadDemo.PrintNumbers);
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
            //WriteLine("Starting programing...");
            //var t4 = new Thread(ThreadDemo.PrintNumbersWithDelay);
            //t4.Start();
            //Sleep(TimeSpan.FromSeconds(6));
            //t4.Abort();
            //WriteLine("A Thread has been aborted");
            //var t41 = new Thread(ThreadDemo.PrintNumbers);
            //t41.Start();
            //ThreadDemo.PrintNumbers();

            //lesson 5
            //线程的不同状态
            //当主程序启动时定义了两个不同的线程。—个将被终止,另一个则会成功完成运行。
            //在一个周期为30次迭代的区间中, 线程状态会从 ThreadState.Running变为ThreadState.WaitSleepJoin
            //如果实际情况与以上不符,请增加迭代次数。
            //终止第一个线程后,会看到现在该线程状态为Aborted。程序也有可能会打印出AbortRequested状态。
            //WriteLine("Starting program...");
            //var t5 = new Thread(ThreadDemo.PrintNumbersWithStatus);
            //var t51 = new Thread(ThreadDemo.DoNothing);
            //WriteLine(t5.ThreadState.ToString());
            //t51.Start();
            //t5.Start();
            //for (var i = 1; i < 30; i++)
            //{
            //    WriteLine(t5.ThreadState.ToString());
            //}
            ////主线程被暂停，ThreadState状态改变
            //Sleep(TimeSpan.FromSeconds(6));
            //t5.Abort();
            //WriteLine("a thread has been aborted ");
            //WriteLine(t5.ThreadState.ToString());
            //WriteLine(t51.ThreadState.ToString());

            //lesson 6
            //线程优先级
            //第一个线程优先级为ThreadPriority.Highest,即具有最高优先级。
            //第二个线程优先级为ThreadPriority.Lowest,即具有最低优先级。
            //我们先打印出主线程的优先级值，然后在所有可用的CPU核心上后动这两个线程
            //如果拥有1个以上的计算核心，将在两秒钟内得到初步结果。
            //最高优先级的线程通常会计算更多的迭代，但是两个值应该很接近。
            //然而，如果有其他程序占用了所有的CPU核心运行负载，结果则会截然不同。
            //为了模拟该情形，设置ProcessorAffinity选项，让操作系统将所有的线程运行在单个CPU核心（第一个核心）上
            //现在结果完全不同，并且计算耗时将超过2Sb钟。这是因为CPU核心大部分时间
            //在运行高优先级的线程，只留给剩下的线程很少的时间来运行
            //WriteLine($"Current thread priority: {CurrentThread.Priority}");
            //WriteLine("running on all cores available");
            //ThreadRun.RunThreads();
            //Sleep(TimeSpan.FromSeconds(2));
            //WriteLine("running on a single core");
            //GetCurrentProcess().ProcessorAffinity = new IntPtr(1);
            //ThreadRun.RunThreads();

            //lesson 7
            //第1个线程完成后，程序结束并且后台线程被终结。
            //这是前台线程与后台线程的主要区别：
            //进程会等待所有的前台线程完成后再结束工作，但是如果只剩下后台线程，则会直接结束工作
            //如果程序定义了一t不会完成的前台线程，主程序并不会正常结束。
            var foreground = new ThreadBackgroundDemo(10);
            var background = new ThreadBackgroundDemo(20);
            var threadOne = new Thread(foreground.CountNumbers)
            {
                Name = "foregroundOne"
            };
            var threadTwo = new Thread(background.CountNumbers)
            {
                Name = "backgroundTwo",
                IsBackground = true
            };
            threadOne.Start();
            threadTwo.Start();
        }
    }
}
