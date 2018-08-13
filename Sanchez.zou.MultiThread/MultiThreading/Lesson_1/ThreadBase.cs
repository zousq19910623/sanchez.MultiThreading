using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;

namespace MultiThreading.Lesson_1
{
    public class ThreadBase
    {
        protected static string GetCurrentThreadId()
        {
            return $"{CurrentThread.ManagedThreadId}";
        }

        protected static string GetCurrentThreadName()
        {
            return $"{CurrentThread.Name}";
        }
    }
}
