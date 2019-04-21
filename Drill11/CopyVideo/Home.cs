using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace CopyVideo
{
    class Home
    {
       static int cursor = 8;
        public static void HomePage()
        {
            Console.CursorVisible = false;
            Drive d = new Drive();
            
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(50, 8);
            if (cursor == Console.CursorTop)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Copy This Session");
            Console.ForegroundColor = ConsoleColor.Black;
          
            Console.SetCursorPosition(50, 11);
            if (cursor == Console.CursorTop)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Special Copy");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(50, 14);
            if (cursor == Console.CursorTop)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Select Source Folder");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(50, 17);
            if (cursor == Console.CursorTop)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine("Exit");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(47, cursor);
            Console.Write("  ");

    
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Enter:
                    if (Console.CursorTop == 8)
                    {
                       
                        if (File.Exists("CopyLocation.txt"))
                        {
                            StreamReader sr = new StreamReader("CopyLocation.txt");
                            DirectoryInfo di = new DirectoryInfo(Convert.ToString(sr.ReadLine()));
                            DirectoryInfo[] direct = di.GetDirectories();
                            FileInfo[] f = di.GetFiles();
                            DriveInfo[] drive = DriveInfo.GetDrives();
                            string[] show = new string[drive.Length];
                            for (int i = 0; i < drive.Length; i++)
                            {
                                if (drive[i].IsReady)
                                {
                                    if (Convert.ToString(drive[i].DriveType) == "Removable")
                                    {
                                        for (int j = 0; j < f.Length; j++)
                                        {
                                            
                                            if ((f[j].LastWriteTime).Year == DateTime.Now.Year)
                                            {
                                                if ((f[j].LastWriteTime).Month == DateTime.Now.Month)
                                                {
                                                    if ((f[j].LastWriteTime).Day == DateTime.Now.Day)
                                                    {
                                                        if (f[j].Length< drive[i].TotalFreeSpace)
                                                        {
                                                            double a = drive[i].TotalFreeSpace;
                                                            File.Copy(Convert.ToString(f[j].FullName), $"{Convert.ToString(drive[i])}" +
                                                                                                                      $"\\{f[j].Name}", true);
                                                            if (a > drive[i].TotalFreeSpace)
                                                            {
                                                                show[i] = drive[i].Name+" Transfer Successfuly";
                                                            }
                                                            else
                                                            {
                                                                if (f[j].Length > drive[i].TotalFreeSpace)
                                                                {
                                                                    show[i] = drive[i].Name+" Not Enough Storage Space";
                                                                }
                                                                else
                                                                {
                                                                    show[i] = drive[i].Name+" Transfer Failed";
                                                                }
                                                            }
                                                        }
                                                      
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            string finalshow ="\n\n\n\n\n\n\n\n";
                            for (int i = 0; i < drive.Length; i++)
                            {
                                if (drive[i].IsReady)
                                {
                                    if (Convert.ToString(drive[i].DriveType) == "Removable")
                                    {
                                        finalshow += $"\t\t\t\t\t\t{show[i]}\n\n\n";
                                        Console.Clear();
                                     
                                    }

                                }
                                
                            }
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                           
                            Console.WriteLine(finalshow);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.ReadKey();
                            Home.HomePage();
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
                            HomePage();
                        }
                    }
                    if (Console.CursorTop == 11)
                    {
                        Special.Copy();
                    }
                    if (Console.CursorTop == 14)
                    {
                        d.ShowDrives();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (Console.CursorTop == 8)
                    {
                        cursor = 17;
                    }
                    else
                    {
                        cursor -= 3;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Console.CursorTop == 17)
                    {
                        cursor = 8;
                    }
                    else
                    {
                        cursor += 3;
                    }
                    break;
            }
            HomePage();
        }
        public void Destination()
        {

        }
    }
}
