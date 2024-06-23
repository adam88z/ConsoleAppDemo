using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo.Models
{
    internal class Counter
    {
        internal int Count()
        {
            Console.WriteLine("begin");
            Thread thread = Thread.CurrentThread;
            Thread thread1 = new Thread(CountUp);
            Thread thread2 = new Thread(new ThreadStart(CountDown));
            thread1.Start();
            thread2.Start();
            return 0;
        }

        public static void CountUp()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("CountUp counter: " + i + "");
                Thread.Sleep(500);
            }
        }
        public static void CountDown()
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("CountDown counter: " + i + "");
                Thread.Sleep(500);
            }
        }

    }
}
