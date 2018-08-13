using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;
using static System.Diagnostics.Process;

namespace MultiThreading.Lesson_1
{
    public class ThreadPriorityDemo : ThreadBase
    {
        private bool _isStopped = false;

        public void Stop()
        {
            _isStopped = true;
        }

        public void CountNumbers()
        {
            long counter = 0;
            while (!_isStopped)
            {
                counter++;
            }

            WriteLine($"{GetCurrentThreadName()} with {CurrentThread.Priority,11} Priority, has a counter {counter,13:N0}");
        }
    }
}
