using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07DeleteElement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Number Of Elements:");
            int element = Convert.ToInt32(Console.ReadLine());
            int[] duplicate = new int[element];
            for (int i = 0; i < duplicate.Length; i++)
            {
                Console.Write($"Element-{i}=");
                duplicate[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the element where to delete:");
            int delete = Convert.ToInt32(Console.ReadLine());
            Console.Write(" the new list is=");
            for (int i = 0; i < duplicate.Length; i++)
            {
                    if (duplicate[i] != delete)
                    {
                    Console.Write($" \n \t \t{duplicate[i]} ");
                }
                
                
            }
           
            Console.ReadKey();
        }
    }
}
