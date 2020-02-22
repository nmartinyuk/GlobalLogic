using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IMovable
    {
        void Move();

        void Stop();

        protected void Test();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }
    }
}
