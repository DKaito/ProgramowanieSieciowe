using System;
using System.Threading;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread printingThread = new Thread(PrintHelloWorld);
            printingThread.Start();
            printingThread.Join();
        }

        static void PrintHelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
