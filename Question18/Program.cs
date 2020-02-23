using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question18
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            string s2 = "Hello";

            if (object.ReferenceEquals(s1, s2))
                Console.WriteLine("Same objects");
            else
                Console.WriteLine("Not the same objects");
            int x = 2;
            if (x != null)
            {
                Console.WriteLine("2 is not null");
            }

            Console.WriteLine(object.ReferenceEquals(10, 10));

            Console.WriteLine(object.Equals(2, null));
            Console.ReadLine();
        }
    }

    class A
    {
        public int x;

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }

    class B : A
    {

    }
}
