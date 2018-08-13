using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;

namespace MultiThreading.Lesson_1
{
    public class ThreadRun
    {
        public static void RunThreads()
        {
            var sample = new ThreadPriorityDemo();

            var threadOne = new Thread(sample.CountNumbers) { Name = "ThreadOne" };
            var threadTwo = new Thread(sample.CountNumbers) { Name = "ThreadTwo" };

            threadOne.Priority = ThreadPriority.Highest;
            threadTwo.Priority = ThreadPriority.Lowest;

            threadOne.Start();
            threadTwo.Start();

            Sleep(TimeSpan.FromSeconds(2));
            sample.Stop();
        }
    }
}
