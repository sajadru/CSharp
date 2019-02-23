using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01PalindromeText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Text:");
            //Palindrome Text = pt
            string pt = Console.ReadLine();
            switch (pt.Length%2)
            {
                case 0:
                    Console.WriteLine("False");
                    break;
                default:
                    Console.WriteLine("True");
                    break;
            }
            Console.ReadKey();
        }
    }
}
