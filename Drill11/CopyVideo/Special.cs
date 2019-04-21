using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyVideo
{
    class Special
    {
      static int curx = 2;
       static int cury = 3;
        public static void Copy()
        {
           
           
            if (File.Exists("CopyLocation.txt"))
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.SetCursorPosition(104,1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("<<Esc = Back>>");
                Console.SetCursorPosition(2, 1);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("<<Enter = OK>>");
                StreamReader sr2 = new StreamReader("CopyLocation.txt");
                DirectoryInfo di2 = new DirectoryInfo(Convert.ToString(sr2.ReadLine()));
                DirectoryInfo[] direct2 = di2.GetDirectories();
                FileInfo[] f2 = di2.GetFiles();

                for (int j = 0; j < 3; j++)
                {
                    
                    for (int i = 0+j; i < f2.Length; i += 3)
                    {
                        int x = (j * 40)+5;
                        int y = i + 3 - j;
                        Console.ForegroundColor = ConsoleColor.White;


                        Console.SetCursorPosition(x,y);
                        if (Console.CursorTop == cury && Console.CursorLeft == curx+3)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine(f2[i].Name);
                        }
                        else
                        {
                            Console.WriteLine(f2[i].Name);
                        }

                    }
                }
                Console.SetCursorPosition(curx, cury);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("  ");
                ConsoleKey key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.Enter:
                        Console.SetCursorPosition(curx, cury);
                       
                        int final = 0;
                                    if (Console.CursorLeft == 2)
                                    {
                                        final = Console.CursorTop-3;
                                    }
                                    if (Console.CursorLeft == 42)
                                    {
                                        final = Console.CursorTop - 2;
                                    }
                                    if (Console.CursorLeft == 82)
                                    {
                                        final = Console.CursorTop - 1;
                                    }
                       
                            StreamReader sr = new StreamReader("CopyLocation.txt");
                            DirectoryInfo di = new DirectoryInfo(Convert.ToString(sr.ReadLine()));
                            DirectoryInfo[] direct = di.GetDirectories();
                            FileInfo[] f = di.GetFiles();
                            DriveInfo[] drive = DriveInfo.GetDrives();
                            for (int i = 0; i < drive.Length; i++)
                            {
                                if (drive[i].IsReady)
                                {
                                    if (Convert.ToString(drive[i].DriveType) == "Removable")
                                    {
                               
                                      if (f[final].Length < drive[i].TotalFreeSpace)
                                      {
                                       File.Copy(Convert.ToString(f[final].FullName), $"{Convert.ToString(drive[i])}" +
                                                                                                 $"\\{f[final].Name}", true);

                                      }
                                        else
                                        {
                                          Console.Clear();
                                          Console.SetCursorPosition(45, 13);
                                          Console.ForegroundColor = ConsoleColor.Red;
                                          Console.WriteLine("Drive " + drive[i].Name + " storage space is not enough!");
                                          Console.ForegroundColor = ConsoleColor.Gray;
                                          Console.ReadKey();
                                          Special.Copy();
                                        }                 
                                    }
                                }
                                      
                            }
                            Console.Clear();
                            Console.SetCursorPosition(48, 13);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Transfer successfully :)");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.ReadKey();
                            Home.HomePage();
                        
                        break;
                    case ConsoleKey.Escape:
                        Home.HomePage();
                        break;
                    case ConsoleKey.UpArrow:
                        if (Console.CursorTop==3)
                        {
                            if (Console.CursorLeft == 5)
                            {
                                for (int i = 0 ; i < f2.Length; i += 3)
                                {
                                    cury = i + 3;
                                }
                            }
                            if (Console.CursorLeft == 45)
                            {
                                for (int i = 1; i < f2.Length; i += 3)
                                {
                                    cury = i + 3-1;
                                }
                            }
                            if (Console.CursorLeft == 85)
                            {
                                for (int i = 2; i < f2.Length; i += 3)
                                {
                                    cury = i + 3-2;
                                }
                            }
                        }
                        else
                        {
                            cury -= 3;      
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Console.CursorLeft == 5)                   
                        {
                            int sample =0;
                                for (int i = 0; i < f2.Length; i += 3)
                                {
                                     sample= i + 3;
                                }
                            if (cury == sample)
                            {
                                cury = 0;
                            }
                        }
                        if (Console.CursorLeft == 45)
                        {
                            int sample = 0;
                            for (int i = 1; i < f2.Length; i += 3)
                            {
                                sample = i + 2;
                            }
                            if (cury == sample)
                            {
                                cury = 0;
                            }
                        }
                        if (Console.CursorLeft == 85)
                        {
                            int sample = 0;
                            for (int i = 2; i < f2.Length; i += 3)
                            {
                                sample = i + 1;
                            }
                            if (cury == sample)
                            {
                                cury = 0;
                            }
                        }
                        if (true)
                        {
                            cury += 3;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Console.CursorLeft == 5)
                        {
                            int a = 0;
                                for (int i = 2; i < f2.Length; i += 3)
                                {
                                    a = i + 1;
                                }
                            if (Console.CursorTop <= a)
                            {
                                curx = 82;
                            }
                            else
                            {
                                int b = 0;
                                for (int i = 1; i < f2.Length; i += 3)
                                {
                                    b = i + 2;
                                }
                                if (Console.CursorTop <= b)
                                {
                                    curx = 42;
                                }
                               
                            }
                        }
                        else
                        {
                            curx -= 40;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Console.CursorLeft == 85)
                        {
                            curx = 2;
                        }
                        if (Console.CursorLeft == 5)
                        {
                            int a = 0;
                            for (int i = 1; i < f2.Length; i += 3)
                            {
                                a = i + 2;
                            }
                            if (Console.CursorTop <= a)
                            {
                                curx = 42;
                            }
                        }
                        if (Console.CursorLeft == 45)
                        {
                            int a = 0;
                            for (int i = 2; i < f2.Length; i += 3)
                            {
                                a = i + 1;
                            }
                            if (Console.CursorTop <= a)
                            {
                                curx = 82;
                            }
                            else
                            {
                                curx = 2;
                            }
                        }
                     
                        break;
                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(49, 10);
                Console.WriteLine(" Not Found Adress");
                Console.SetCursorPosition(49, 12);
                Console.WriteLine("Please Set Adress");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Home.HomePage();
            }
            Special.Copy();
        }
    }
}
