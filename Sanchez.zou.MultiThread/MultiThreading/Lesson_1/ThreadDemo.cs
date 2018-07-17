using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;

namespace MultiThreading.Lesson_1
{
    public static class ThreadDemo
    {
        private static string GetCurrentThreadId()
        {
            return $"current thread id:{CurrentThread.ManagedThreadId}";
        }

        public static void PrintNumbers()
        {
            WriteLine("Starting ...");
            for (var i = 1; i < 10; i++)
            {
                WriteLine($" Starting--{i}");
            }
        }

        public static void PrintNumbersWithDelay()
        {
            WriteLine($"{GetCurrentThreadId()}--Starting WithDelay ...");
            for (var i = 1; i < 10; i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine($"{GetCurrentThreadId()}--Starting WithDelay--{i}");
            }
        }

        public static void PrintNumbersWithStatus()
        {
            WriteLine($"{GetCurrentThreadId()}--Starting WithStatus ...");
            WriteLine($"当前线程状态：{CurrentThread.ThreadState}");
            for (var i = 1; i < 10; i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine($"{GetCurrentThreadId()}--Starting WithStatus--{i}");
            }
        }

        public static void DoNothing()
        {
            WriteLine($"{GetCurrentThreadId()}--Starting WithNothing ...");
            Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
