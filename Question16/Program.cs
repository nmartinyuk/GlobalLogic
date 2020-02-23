using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question16
{
    // Если делегат возвращает значение, то им становится значение, возвращаемое последним методом в списке вызовов. 
    // Поэтому делегат, в котором используется групповая адресация, обычно имеет возвращаемый тип void
    public delegate void Greeting(string name);

    class Program
    {
        public static event Greeting Farewell;

        static void Main(string[] args)
        {
            string name = "User1";

            //Greeting greeting = null;
            Greeting greeting = new Greeting(Program.Hello);
            greeting -= Hello;
            //greeting += Привет;
            Console.WriteLine(greeting.GetInvocationList());
            greeting.Invoke(name);

            Farewell += Bye;
            Farewell += Пока;

            if (Farewell != null)
            {
                Farewell(name);
            }
            else
            {
                Console.WriteLine("I have no one to say goodbye to");
            }

            Console.ReadLine();
        }

        static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        static void Привет(string name)
        {
            Console.WriteLine($"Привет, {name}");
        }

        static void Bye(string name)
        {
            Console.WriteLine($"Bye, {name}");
        }

        static void Пока(string name)
        {
            Console.WriteLine($"Пока, {name}");
        }
    }
}
