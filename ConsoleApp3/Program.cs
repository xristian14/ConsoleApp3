using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = Int32.Parse(a);
            int c = 1;
            for(int i = 1; i <= b; i++)
            {
                c = c * i;
            }
            Console.WriteLine(b + "! = " + c);
            Console.ReadLine();
        }
    }
}
