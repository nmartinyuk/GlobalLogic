using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question17
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new DerivedClass();
            baseClass.New();
            baseClass.Override();
            Console.ReadLine();
        }
    }

    class BaseClass
    {
        public void New()
        {
            Console.WriteLine("BaseClass.New");
        }

        public virtual void Override()
        {
            Console.WriteLine("BaseClass.Override");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void New()
        {
            Console.WriteLine("DerivedClass.New");
        }

        public override void Override()
        {
            Console.WriteLine("Derived.Override");
        }
    }
}
