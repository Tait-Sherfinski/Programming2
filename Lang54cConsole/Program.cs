using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lang54cConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radius: ");
            int radius = int.Parse(Console.ReadLine());
            double circ = 2 * 3.14 * radius;
            double area = 3.14 * (radius * radius);

            Console.WriteLine("Circumference: " + circ);
            Console.WriteLine("Area: " + area);
            Console.ReadLine();
        }
    }
}
