
using System.Diagnostics;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("begin");
        Thread thread = Thread.CurrentThread;
        Thread thread1 = new Thread(new ThreadStart(CountUp));

        Thread thread2 = new Thread(new ThreadStart(CountDown));
        thread1.Start();
        thread2.Start();
    }


    public static void CountUp()
    {
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("CountUp counter: " + i + "");
            Thread.Sleep(500);
        }
    }
    public static void CountDown()
    {
        for(int i = 10; i > 0; i--)
        {
            Console.WriteLine("CountDown counter: " + i + "");
            Thread.Sleep(500);
        }
    }
}