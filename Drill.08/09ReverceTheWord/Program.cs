using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ReverceTheWord
{
    class Program
    {
        static void Main(string[] args)
        {


            string final = string.Empty;
            Console.WriteLine("Enter Your Sentence:");
            string sentence = Console.ReadLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (Convert.ToChar(sentence[i]) == ' ') 
                {
                    for (int j = i-1; j >= 0; j--)
                    {
                        if (Convert.ToChar(sentence[j]) == ' ')
                        {
                            break;
                        }
                        final += sentence[j];
                    }
                    final += " ";
                }
            }
            for (int i = sentence.Length-1 ; i > 0; i--)
            {
                if (Convert.ToChar(sentence[i]) == ' ')
                {
                    break;
                }
                final += sentence[i];
            }
            Console.WriteLine(final);
            Console.ReadKey();
        }
    }
}
