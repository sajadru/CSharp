using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class HomePage
    {
        public void list()
        {     int A =0;
            DynamicArray d = new DynamicArray();
            Cursor c = new Cursor();
            int cursor = 10;
            Book b = new Book();
            Book[] fact = new Book[1];
           
            bool t = true;
            while (t)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();

                c.Cur(50, 10);
                Console.WriteLine("-Show All Books");

                c.Cur(50, 12);
                Console.WriteLine("-Add Book");
                c.Cur(50, 14);
                Console.WriteLine("-Edit Book");
                c.Cur(50, 16);
                Console.WriteLine("-Delete Book");
                c.Cur(50, 18);
                Console.WriteLine("-Exit");


                Console.SetCursorPosition(48, cursor);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Write("  ");
                Console.SetCursorPosition(49, cursor);

                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        switch (Console.CursorTop)
                        {
                            case 10:
                             
                                if (A>0)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Black;
                                c.Cur(15, 1);
                                Console.Write("Name");
                                c.Cur(35, 1);
                                Console.Write("ISBN");
                                c.Cur(55, 1);
                                Console.Write("Author");
                                c.Cur(75, 1);
                                Console.Write("Publisher");
                                c.Cur(99, 1);
                                Console.Write("Year");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    for (int i = 0; i < fact.Length ; i++)
                                    {
                                        c.Cur(13, i + 3);
                                        Console.WriteLine(Book.Name);
                                        c.Cur(32, i + 3);
                                        Console.WriteLine(Book.Isbn);
                                        c.Cur(53, i + 3);
                                        Console.WriteLine(Book.Author);
                                        c.Cur(74, i + 3);
                                        Console.WriteLine(Book.Publisher);
                                        c.Cur(96, i + 3);
                                        Console.WriteLine(Book.Year);
                                    }
                                    Console.ReadKey();
                                    
                                }
                                else
                                {
                                    Console.Clear();
                                    c.Cur(49,6);
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Library is empty;");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                break;
                            case 12:
                                Console.Clear();
                                c.Cur(15, 1);
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write("Name");
                                c.Cur(35, 1);
                                Console.Write("ISBN");
                                c.Cur(55, 1);
                                Console.Write("Author");
                                c.Cur(75, 1);
                                Console.Write("Publisher");
                                c.Cur(99, 1);
                                Console.Write("Year");
                                Console.ForegroundColor = ConsoleColor.White;
                                for (int i = fact.Length-1; i <= fact.Length; i++)
                                {
                                  
                                    c.Cur(13, 3);
                                    Book.Name = (Console.ReadLine());

                                    c.Cur(32, 3);
                                    Book.Isbn = (Console.ReadLine());
                                    c.Cur(53, 3);
                                    Book.Author = (Console.ReadLine());
                                    c.Cur(74, 3);
                                    Book.Publisher = (Console.ReadLine());
                                    c.Cur(96, 3);
                                    Book.Year = (Convert.ToDateTime(Console.ReadLine()));
                                    fact[i] = b;
                                    //d.AddArray(ref fact);
                                    A += 1;
                                    break;
                                }
                                break;
                            case 14:
                                Console.Clear();
                                c.Cur(30,5);

                                Console.WriteLine("Book ISBN =");
                                Console.ReadKey();
                                break;
                            case 16:

                                if (A > 0)
                                {
                                    int cursorD = 3;
                                    bool D = true;
                                    while (D)
                                    {
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        c.Cur(15, 1);
                                        Console.Write("Name");
                                        c.Cur(35, 1);
                                        Console.Write("ISBN");
                                        c.Cur(55, 1);
                                        Console.Write("Author");
                                        c.Cur(75, 1);
                                        Console.Write("Publisher");
                                        c.Cur(99, 1);
                                        Console.Write("Year");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        for (int i = 0; i < fact.Length - 1; i++)
                                        {
                                            c.Cur(13, i + 3);
                                            Console.Write(Book.Name);
                                            c.Cur(32, i + 3);
                                            Console.Write(Book.Isbn);
                                            c.Cur(53, i + 3);
                                            Console.Write(Book.Author);
                                            c.Cur(74, i + 3);
                                            Console.Write(Book.Publisher);
                                            c.Cur(96, i + 3);
                                            Console.Write(Book.Year);
                                        }
                               
                                            c.Cur(1, cursorD);
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.Write("DELETE");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            ConsoleKey key2 = Console.ReadKey().Key;
                                            switch (key2)
                                            {
                                                case ConsoleKey.Enter:
                                                if (fact.Length == 2)
                                                {
                                                    fact[0] = null;
                                                    Console.Clear();
                                                    c.Cur(49, 6);
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("Library is empty;");
                                                    Console.ResetColor();
                                                    Console.ReadKey();
                                                    A = 0;
                                                }
                                                else
                                                {
                                                    Book[] factD = new Book[fact.Length - 1];
                                                    for (int j = 0; j < fact.Length; j++)
                                                    {
                                                        if (fact[Console.CursorTop - 3] == fact[j])
                                                        {
                                                            
                                                        }
                                                        else
                                                        {
                                                            factD[j] = fact[j];
                                                        }

                                                    }
                                                    fact = factD;
                                                }
                                                D = false;
                                                    break;
                                                case ConsoleKey.UpArrow:
                                                    if (Console.CursorTop == 3)
                                                    {
                                                        cursorD = fact.Length + 2;
                                                    }
                                                    else
                                                    {
                                                        cursorD -= 1;
                                                    }
                                                    break;
                                                case ConsoleKey.DownArrow:
                                                    if (Console.CursorTop == fact.Length + 1)
                                                    {
                                                        cursorD = 3;
                                                    }
                                                    else
                                                    {
                                                        cursorD += 1;
                                                    }
                                                    break;
                                            }

                                        } 
                                      
                                }
                                else
                                {
                                    Console.Clear();
                                    c.Cur(49, 6);
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("Library is empty;");
                                    Console.ResetColor();
                                    Console.ReadKey();
                                }
                                break;
                            case 18:
                                t = false;
                                Console.Clear();
                                break;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop == 10)
                        {
                            cursor = 18;
                        }
                        else
                        {
                            cursor = (Console.CursorTop) - 2;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop == 18)
                        {
                            cursor = 10;
                        }
                        else
                        {
                            cursor = (Console.CursorTop) + 2;




                        }
                        break;

                }
            }
        }
    }
}
