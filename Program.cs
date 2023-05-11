using System.Threading;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(new ThreadStart(Count));
            //myThread.IsBackground = true;
            myThread.Priority = ThreadPriority.Highest;
            myThread.Start();

            for (int i = 0; i < 9; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Primary");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
        }

        public static void Count()
        {
            Thread.Sleep(300);
            for (int i = 0; i < 9; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Secondary");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }
    }
}