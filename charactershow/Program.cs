using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace charactershow
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "c# Programing";
            foreach (char c in str)
            {
                Console.Write(c);
                Thread.Sleep(100);
                
            }
            Console.WriteLine();

            string str2 = "welcome to programing class";
            foreach (char c in str2)
            {
                Console.Write(c);
                Thread.Sleep(100);

            }

            Console.WriteLine();

            string str3 = "let's start your first program :)";
            foreach (char c in str3)
            {
                Console.Write(c);
                Thread.Sleep(100);

            }
            Console.ReadKey();
        }
    }
}
