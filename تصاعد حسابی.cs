using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تصاعد_حسابی
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, e1, e2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            e1 = num1 - num2;
            e2 = num2 - num3;
            if (e1 == e2)
                Console.WriteLine("سه عدد تصاعد حسابی تشکیل می دهند");
            else
                Console.WriteLine("سه عدد تصاعد حسابی تشکیل نمی دهند");
            Console.ReadLine());
        }
    }
}
