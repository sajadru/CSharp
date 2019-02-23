using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Sphere
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter Radius:");
            double radius = Convert.ToDouble(Console.ReadLine());
            double volume = 4 / 3 * (Math.Pow(radius, 3)) * Math.PI;
            double surface = 4 * (Math.Pow(radius, 2)) * Math.PI;

            Console.WriteLine($"Volume={volume}");
            Console.WriteLine($"Surface={surface}");
            Console.ReadKey();
        }
    }
}
