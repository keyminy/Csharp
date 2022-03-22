using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 예제_3
{
    class Program
    {
        static private int a=0;
    
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine("a = " + a++);
            Console.WriteLine("++한 후 a = " + a);
                        
        }
        static private void Func1(int a)
        {
            a = 2;
        }
    }
}
