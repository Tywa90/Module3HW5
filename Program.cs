using System.Threading;

namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Run();
        }
    }
}