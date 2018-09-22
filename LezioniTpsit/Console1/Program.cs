using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            //write();
            //Console.Writeline("Hello Word");
            Task t = new Task(write);
            t.Start();


            int i = 100;
            while (i > 0)
            {
                Console.Write("Raul");
                i = i - 1;
            }
            Console.ReadLine();
        }
        public static void write()
        {
            int i = 100;
            while (i > 0)
            {
                i--;
                Console.Write(i);
            }
        }
    }
}
