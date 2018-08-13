using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;

namespace MultiThreading.Lesson_1
{
    public class ThreadBackgroundDemo: ThreadBase
    {
        private readonly int _iterations;

        public ThreadBackgroundDemo(int iterations)
        {
            _iterations = iterations;
        }

        public void CountNumbers()
        {
            for (int i = 0; i < _iterations; i++)
            {
                Sleep(TimeSpan.FromSeconds(0.5));
                WriteLine($"{GetCurrentThreadName()} print {i}");
            }
        }
    }
}
