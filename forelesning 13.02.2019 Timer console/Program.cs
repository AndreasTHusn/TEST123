using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace forelesning_13._02._2019
{
    class Program
    {
        static void SkrivTid(object kilde, ElapsedEventArgs argument)
        {
            int i = 2;
            Console.WriteLine(argument.SignalTime);
        }

        static void SkrivTest(object kilde, ElapsedEventArgs argument)
        {
            Console.WriteLine("Test");
        }

        static void Main(string[] args)
        {
            Timer minTimer = new Timer(1000);
            minTimer.Elapsed += new ElapsedEventHandler(SkrivTid);
            minTimer.Elapsed += new ElapsedEventHandler(SkrivTest);
            minTimer.Start();

            Console.ReadLine();
        }
    }
}
