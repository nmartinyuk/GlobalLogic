using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            //string s = x as string;
            if (x is string)
            {
                Console.WriteLine("int");
            }
            Console.ReadLine();
        }
    }
}
