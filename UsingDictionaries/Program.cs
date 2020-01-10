using System;
using static System.Console;
using System.Threading;
using UsingDictionaries;
using System.Collections.Generic;

namespace UsingDictionaries
{
    

    class Program
    {
        public static void Silnia(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                i *= n;
            }
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(() => Silnia(100));
            Dictionary<int, Thread> NT = new Dictionary<int, Thread>
            {
                //NT.Add(0, t0);
                { 1, t1 }
            };
        }
    }
}
