using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CompleteRange
{
    class Program
    {
        static int Range(int[] cr)
        {
            int sum = 0;
            Array.Sort(cr);

            for (int i = 0; i < cr.Length - 1; i++)
            {
                if (cr[i+1]==0 || cr[i]==0)
                {
                    continue;
                }
                sum += (cr[i + 1] - cr[i])-1;
               
            }
            return sum;
        }
        static void Main(string[] args)
        {
            
            int[] cr2 = new int[1000];
            Console.WriteLine("Enter Numbers Then Write END");
            for (int i = 0; i <100000 ;i++ )
            {
                Console.Write("Enter:");
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }
                cr2[i] = Convert.ToInt32(input);
                
            }
            int final = Range(cr2);
            Console.WriteLine(final);
            Console.ReadKey();
        }
    }
}
