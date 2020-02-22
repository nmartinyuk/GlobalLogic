using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A { x = 10 };
            RefObject(a);
            Console.WriteLine(a.x);
            RefInt(ref a.x);
            Console.WriteLine(a.x);
            Console.ReadLine();
        }

        static void RefObject(A a)
        {
            a.x++;
        }

        static void RefInt(ref int n)
        {
            n++;
        }
    }

    public class A
    {
        public int x;
    }
}
