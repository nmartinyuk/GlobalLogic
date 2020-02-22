using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovable car = new Car();
            car.Move();
            car.Stop();
            IMovable plane = new IMovable();
            Console.ReadLine();
        }
    }

    public interface IMovable
    {
        void Move();

        void Stop();
    }

    class Car : IMovable
    {
        public void Move()
        {
            this.TurnOn();
            Console.WriteLine("Car is moving");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
            this.TurnOff();
        }

        public void TurnOn()
        {
            Console.WriteLine("Car's engine is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Car's engine is off");
        }
    }
}
