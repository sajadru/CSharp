using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FrequencyElement
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
            for (int i = 0; i < duplicate.Length; i++)
            {
                int final = 0;
                for (int j = i ; j < duplicate.Length; j++)
                {
                    if (duplicate[i] == duplicate[j])
                    {
                        final += 1;
                    }
                }
                Console.WriteLine($" \n {duplicate[i]} occurs { final} times.");
            }
            
            Console.ReadKey();
        }
    }
}
