using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question19
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Point> points = new HashSet<Point>();

            points.Add(new Point
            {
                x = 1, y = 1
            });
            points.Add(new Point
            {
                x = 2,
                y = 2
            });

            Point p1 = new Point
            {
                x = 1,
                y = 1
            };

            points.Add(p1);
            Console.WriteLine(points.Count);
            Console.ReadLine();
        }
    }

    struct Point : IEquatable<Point>
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("object.Equals called");
            Point other = (Point)obj;
            return this.x == other.x && this.y == other.y;
        }

        public bool Equals(Point other)
        {
            Console.WriteLine("Point.Equals called");
            return this.x == other.x && this.y == other.y;
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Point.GetHashCode called");
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
    }
}
