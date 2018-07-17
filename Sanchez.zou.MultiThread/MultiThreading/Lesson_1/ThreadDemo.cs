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
        public static void PrintNumbers()
        {
            WriteLine("Starting ...");
            for (var i = 1; i < 10; i++)
            {
                WriteLine($"Starting--{i}");
            }
        }

        public static void PrintNumbersWithDelay()
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
