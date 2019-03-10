using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyVideo
{
    class Drive
    {
        int cursor = 0;
        public string ShowDrives()
        {

                Directory di = new Directory();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                DriveInfo[] d = DriveInfo.GetDrives();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                for (int i = 0; i < d.Length; i++)
                {

                    Console.SetCursorPosition(4, i);
                    Console.WriteLine(d[i]);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(4, d.Length);
                Console.WriteLine("Back");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, cursor);
                Console.Write("  ");
                ConsoleKey key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.Enter:
                        if (Console.CursorTop == d.Length)
                        {
                            return " ";
                        }
                        else
                        {
                            string a = Convert.ToString(d[Console.CursorTop]);
                            di.ShowDirectory(a);
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop == 0)
                        {
                            cursor = d.Length;
                        }
                        else
                        {
                            cursor -= 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorTop == d.Length)
                        {
                            cursor = 0;
                        }
                        else
                        {
                            cursor += 1;
                        }
                        break;
                }

                ShowDrives();

            return "";
        }
    }
    
}
