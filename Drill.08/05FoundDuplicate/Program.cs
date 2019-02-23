using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FoundDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int final = 0;
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
                for (int j = i+1; j < duplicate.Length; j++)
                {
                    if (duplicate[i] == duplicate[j])
                    {
                        final += 1;
                    }
                }

            }
            Console.WriteLine($"Total Number={ final}");
            Console.ReadKey();
        }
    }
}
