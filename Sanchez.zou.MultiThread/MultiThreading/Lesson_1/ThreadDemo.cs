using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Threading.Thread;

namespace MultiThreading.Lesson_1
{
    public class ThreadDemo : ThreadBase
    {
        public static void PrintNumbers()
        {
            WriteLine("Starting ...");
            for (var i = 1; i < 10; i++)
            {
                WriteLine($"current id:{GetCurrentThreadId()} Starting--{i}");
            }
        }

        public static void PrintNumbersWithDelay()
        {
            WriteLine($"current id:{GetCurrentThreadId()}--Starting WithDelay ...");
            for (var i = 1; i < 10; i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine($"current id:{GetCurrentThreadId()}--Starting WithDelay--{i}");
            }
        }

        public static void PrintNumbersWithStatus()
        {
            WriteLine($"current id:{GetCurrentThreadId()}--Starting WithStatus ...");
            WriteLine($"当前线程current id:{GetCurrentThreadId()}状态：{CurrentThread.ThreadState}");
            for (var i = 1; i < 10; i++)
            {
                Sleep(TimeSpan.FromSeconds(2));
                WriteLine($"current id:{GetCurrentThreadId()}--Starting WithStatus--{i}");
            }
        }

        public static void DoNothing()
        {
            WriteLine($"current id:{GetCurrentThreadId()}--Starting WithNothing ...");
            Sleep(TimeSpan.FromSeconds(2));
        }
    }
}
