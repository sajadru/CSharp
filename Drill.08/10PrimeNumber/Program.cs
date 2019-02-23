using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "Prime";
            Console.Write("Enter Your Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num<=1)
            {
                output = "Not Prime";
            }
            for (int i = 2; i < num; i++)
            {
                if (num%i==0)
                {
                    output = "Not Prime";
                }
            }
            Console.WriteLine($"Your Number {output}");
            Console.ReadKey();
        }
    }
}
