using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace کارکتر
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, s=0;
            char r;
            a = int.Parse(Console.ReadLine());
            r = Console.ReadLine().KeyChar;
            b = int.Parse(Console.ReadLine());
            if (r == '*')
                s = a * b;
            else if (r == '/')
                s = a / b;
            else if (r == '-')
                s = a - b;
            else if (r == '+')
                s = a + b;
            Console.WriteLine("s=" + s);
            Console.ReadLine();
        

        }
    }
}
