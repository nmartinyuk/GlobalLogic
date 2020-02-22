using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
            // deferred execution
            var list = new List<string>
            {
                "item1", "item2", "item3"
            };

            var query = from q in list select q;

            list.Add("item4");

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }

            // Variable capturing
            Foo();
            Console.ReadLine();
        }

        static void Foo()
        {
            var actions = new List<Action>();
            for (int i = 0; i < 10; i++)
            {
                actions.Add(() => Console.WriteLine(i));
            }
            foreach (var a in actions)
            {
                a();
            }
        }
    }
}
