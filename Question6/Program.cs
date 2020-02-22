using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Movable
    {
        public string name;

        public abstract void Move();

        public abstract void Stop();

        public Movable(string name)
        {
            this.name = name;
        }
    }

    public class Car : Movable
    {
        public override void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public override void Stop()
        {
            Console.WriteLine("Car has stopped");
        }

        public Car(string name) : base(name)
        {

        }
    }
}
