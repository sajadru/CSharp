using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace CopyVideo
{
    class Home
    {
       static int cursor = 1;
        public static void HomePage(string Adress)
        {
            Console.CursorVisible = false;
            Drive d = new Drive();
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.SetCursorPosition(4, 1);
            Console.WriteLine("Copy This Session");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("Select Source Folder");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("Exit");
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(1, cursor);
            Console.Write("  ");
            ConsoleKey key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.Enter:
                    if (Console.CursorTop == 1)
                    {
                        DirectoryInfo di = new DirectoryInfo(Adress);
                        DirectoryInfo[] direct = di.GetDirectories();
                        FileInfo[] f = di.GetFiles();
                        DriveInfo[] drive = DriveInfo.GetDrives();
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
                                                    File.Copy(Convert.ToString(f[j].FullName), $"{Convert.ToString(drive[i])}" +
                                                        $"\\{f[j].Name}",true);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        } 
                    }
                    if (Console.CursorTop == 3)
                    {
                        d.ShowDrives();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (Console.CursorTop == 1)
                    {
                        cursor = 5;
                    }
                    else
                    {
                        cursor -= 2;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Console.CursorTop == 5)
                    {
                        cursor = 1;
                    }
                    else
                    {
                        cursor += 2;
                    }
                    break;
            }
            HomePage(Adress);
        }
        public void Destination()
        {

        }
    }
}
