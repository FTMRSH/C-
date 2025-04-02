using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace مرتب_کردن_سه_عدد
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(a>b)
            {
                d = a;a = b;b = d;
            }
            if (a > c)
            {
                d = a;a = c;c = d;
            }
            if(b>c)
            {
                d = a;a = c;c = d;
            }
            Console.WriteLine(a + "-" + b + "-" + c + "");
            Console.ReadLine();


        }
    }
}
