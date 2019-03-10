using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyVideo
{
    class Directory
    {
        int cursor = 0;
        public string ShowDirectory(string x)
        {
         
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            DirectoryInfo di = new DirectoryInfo(x);
            DirectoryInfo[] d = di.GetDirectories();
            FileInfo[] f = di.GetFiles();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (int i = 0; i < d.Length; i++)
            {

                Console.SetCursorPosition(4, i);
                Console.WriteLine(d[i]);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 0; i < f.Length; i++)
            {
                Console.SetCursorPosition(4, i+d.Length);
                Console.WriteLine(f[i]);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(4, d.Length+f.Length);
            Console.WriteLine("Back");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(4, d.Length + f.Length+1);
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(1, cursor);
            Console.Write("  ");
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Enter:
                    if (Console.CursorTop == (d.Length + f.Length+1))
                    {
                            File.Delete("CopyLocation.txt");
                            StreamWriter sw = new StreamWriter("CopyLocation.txt");
                            sw.Write(Convert.ToString(x));
                            sw.Close();
                            Home.HomePage();
                    }
            
                    if (Console.CursorTop == d.Length+f.Length)
                    {
                        return " ";
                    }
                    if (Console.CursorTop < d.Length)
                    {
                        Directory m = new Directory();
                        m.ShowDirectory(Convert.ToString(d[Console.CursorTop].FullName));
                    }
                    if (Console.CursorTop >= d.Length && Console.CursorTop < f.Length)
                    {
                        Process.Start(Convert.ToString(f[Console.CursorTop].FullName)); 
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (Console.CursorTop == 0)
                    {
                        cursor = d.Length+f.Length+1;
                    }
                    else
                    {
                        cursor -= 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Console.CursorTop == d.Length+f.Length+1)
                    {
                        cursor = 0;
                    }
                    else
                    {
                        cursor += 1;
                    }
                    break;
            }

            ShowDirectory(x);
            return "";
        }
    }
}
