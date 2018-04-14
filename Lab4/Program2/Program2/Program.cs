using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Thread> threadList = new List<Thread>();
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(printThread);
                //t.Start();
                threadList.Add(t);
            }

           /* foreach (var thread in threadList)
            {
                thread.Join();
            }*/
            while (true)
            {
                if (Console.ReadKey().Equals("q"))
                    break;
            }
            Console.WriteLine("Quitted");
            Console.ReadKey();
        }

        static void printThread()
        {   
            int number = Thread.CurrentThread.ManagedThreadId - 2;
            if (number == 10)
                number = 0;
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                Console.WriteLine(letter + "{0}", number);
                Thread.Sleep(1000);
            }
        }
    }
}
