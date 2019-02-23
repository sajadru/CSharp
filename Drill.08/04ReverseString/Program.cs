using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string textout = string.Empty;
            Console.WriteLine("Enter Your Text:");
            string text = Console.ReadLine();
            for (int i = 0; i <text.Length; i++)
            {
                if (Convert.ToChar(text[i])=='(')
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        if (Convert.ToChar(text[j])==')')
                        {
                            
                                for (int x = j - 1; x > i; x--)
                                {
                                    textout += Convert.ToString(text[x]);

                                }
                            textout += " ";
                            break;    
                        }

                    }

                }
                        
            }

               
            
            Console.WriteLine(textout);
            Console.ReadKey();  
        }
    }
}
