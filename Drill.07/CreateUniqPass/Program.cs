using System;

namespace CreateUniqPass
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "";
            int i = 0;
            Random r = new Random();
            Console.Write("Enter Length Password:");
            int length =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Complexity Password");
            Console.WriteLine("Difficult---Normal---Eazy");
            string complex = Console.ReadLine().ToLower();
            switch (complex)
            {
                case "difficult":
                    while (i <= length)
                    {
                        int j = r.Next(0, 4);
                        switch (j)
                        {
                            case 0:

                                pass += Convert.ToString(Convert.ToChar(r.Next(65, 91)));
                                break;
                            case 1:
                                pass += Convert.ToString(Convert.ToChar(r.Next(97, 123)));
                                break;
                            case 2:
                                pass += Convert.ToString(r.Next(0, 9));
                                break;
                            case 3:
                                pass += Convert.ToString(Convert.ToChar(r.Next(33, 48)));
                                break;
                        }
                        i++;
                    }
                    break;
                case "normal":
                    while (i <= length)
                    {
                        int j = r.Next(0, 3);
                        switch (j)
                        {
                            case 0:

                                pass += Convert.ToString(Convert.ToChar(r.Next(65, 91)));
                                break;
                            case 1:
                                pass += Convert.ToString(Convert.ToChar(r.Next(97, 123)));
                                break;
                            case 2:
                                pass += Convert.ToString(r.Next(0, 9));
                                break;
                        }
                        i++;
                    }
                    break;
                case "eazy":
                    
                    while (i <= length)
                    {
                       int j = r.Next(0,2);
                        switch (j)
                        {
                            case 0:
                               
                              pass += Convert.ToString(Convert.ToChar(r.Next(65, 91))); 
                                break;
                            case 1:
                                pass += Convert.ToString(Convert.ToChar(r.Next(97,123)));
                                break;
                        }
                        i++;
                    }
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid Text");
                    break;
            }

            Console.WriteLine(pass);
            Console.ReadKey();
        }
    }
}
