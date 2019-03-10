using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    class Welcome
    {
        public void Header()
        { 
        Cursor c = new Cursor();
            for (int i = 90; i <= 91; i++)
            {
                c.Welcome(10, 1);
                Console.WriteLine(@" _____  _____");
                Thread.Sleep(i);
                c.Welcome(10, 2);
                Console.WriteLine(@"|_   _||_   _|");
                Thread.Sleep(i);
                c.Welcome(10, 3);
                Console.WriteLine(@"  | | /\ | |");
                Thread.Sleep(i);
                c.Welcome(10, 4);
                Console.WriteLine(@"  | |/  \| |");
                Thread.Sleep(i);
                c.Welcome(10, 5);
                Console.WriteLine(@"  |   /\   |");
                Thread.Sleep(i);
                c.Welcome(10, 6);
                Console.WriteLine(@"  |__/  \__|");
                Thread.Sleep(i);

                c.Welcome(25, 1);
                Console.WriteLine(@" _________");
                Thread.Sleep(i);
                c.Welcome(25, 2);
                Console.WriteLine(@"|_   ___  |");
                Thread.Sleep(i);
                c.Welcome(25, 3);
                Console.WriteLine(@"  | |_  \_|");
                Thread.Sleep(i);
                c.Welcome(25, 4);
                Console.WriteLine(@"  |  _|  _");
                Thread.Sleep(i);
                c.Welcome(25, 5);
                Console.WriteLine(@" _| |___/ |");
                Thread.Sleep(i);
                c.Welcome(25, 6);
                Console.WriteLine(@"|_________|");
                Thread.Sleep(i);

                c.Welcome(40, 1);
                Console.WriteLine(@" _____");
                Thread.Sleep(i);
                c.Welcome(40, 2);
                Console.WriteLine(@"|_   _|  ");
                Thread.Sleep(i);
                c.Welcome(40, 3);
                Console.WriteLine(@"  | |    ");
                Thread.Sleep(i);

                c.Welcome(40, 4);
                Console.WriteLine(@"  | |   _ ");
                Thread.Sleep(i);
                c.Welcome(40, 5);
                Console.WriteLine(@" _| |__/ |");
                Thread.Sleep(i);
                c.Welcome(40, 6);
                Console.WriteLine(@"|________|");
                Thread.Sleep(i);
                if (i == 90)
                {
                    Console.Clear();
                }
                else { break; }
                c.Welcome(55, 1);
                Console.WriteLine(@"   ______ ");
                Thread.Sleep(i);
                c.Welcome(55, 2);
                Console.WriteLine(@" .' ___  |");
                Thread.Sleep(i);
                c.Welcome(55, 3);
                Console.WriteLine(@"/ .'   \_|");
                Thread.Sleep(i);
                c.Welcome(55, 4);
                Console.WriteLine(@"| |");
                Thread.Sleep(i);
                c.Welcome(55, 5);
                Console.WriteLine(@"\ `.___.'\");
                Thread.Sleep(i);
                c.Welcome(55, 6);
                Console.WriteLine(@" `._____.'");
                Thread.Sleep(i);

                c.Welcome(70, 1);
                Console.WriteLine(@"   ____ ");
                Thread.Sleep(i);
                c.Welcome(70, 2);
                Console.WriteLine(@" .'    `.");
                Thread.Sleep(i);
                c.Welcome(70, 3);
                Console.WriteLine(@"/  .--.  \");
                Thread.Sleep(i);
                c.Welcome(70, 4);
                Console.WriteLine(@"| |    | |");
                Thread.Sleep(i);
                c.Welcome(70, 5);
                Console.WriteLine(@"\  `--'  /");
                Thread.Sleep(i);
                c.Welcome(70, 6);
                Console.WriteLine(@" `.____.'");
                Thread.Sleep(i);

                c.Welcome(85, 1);
                Console.WriteLine(@" ____    ____ ");
                Thread.Sleep(i);
                c.Welcome(85, 2);
                Console.WriteLine(@"|_   \  /   _|");
                Thread.Sleep(i);
                c.Welcome(85, 3);
                Console.WriteLine(@"  |   \/   |");
                Thread.Sleep(i);
                c.Welcome(85, 4);
                Console.WriteLine(@"  | |\  /| | ");
                Thread.Sleep(i);
                c.Welcome(85, 5);
                Console.WriteLine(@" _| |_\/_| |_");
                Thread.Sleep(i);
                c.Welcome(85, 6);
                Console.WriteLine(@"|_____||_____|");
                Thread.Sleep(i);

                c.Welcome(100, 1);
                Console.WriteLine(@" _________");
                Thread.Sleep(i);
                c.Welcome(100, 2);
                Console.WriteLine(@"|_   ___  |");
                Thread.Sleep(i);
                c.Welcome(100, 3);
                Console.WriteLine(@"  | |_  \_|");
                Thread.Sleep(i);
                c.Welcome(100, 4);
                Console.WriteLine(@"  |  _|  _");
                Thread.Sleep(i);
                c.Welcome(100, 5);
                Console.WriteLine(@" _| |___/ |");
                Thread.Sleep(i);
                c.Welcome(100, 6);
                Console.WriteLine(@"|_________|");
                Thread.Sleep(i);
            }
            Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(@"          _____  _____    _________      _____           ______        ____      ____    ____     _________ ");
            Thread.Sleep(110);
            Console.WriteLine(@"         |_   _||_   _|  |_   ___  |    |_   _|        .' ___  |     .'    `.   |_   \  /   _|   |_   ___  |");
            Thread.Sleep(110);
            Console.WriteLine(@"           | | /\ | |      | |_  \_|      | |         / .'   \_|    /  .--.  \    |   \/   |       | |_  \_|");
            Thread.Sleep(110);
            Console.WriteLine(@"           | |/  \| |      |  _|  _       | |   _     | |           | |    | |    | |\  /| |       |  _|  _ ");
            Thread.Sleep(110);
            Console.WriteLine(@"           |   /\   |     _| |___/ |     _| |__/ |    \ `.___.'\    \  `--'  /   _| |_\/_| |_     _| |___/ |");
            Thread.Sleep(110);
            Console.WriteLine(@"           |__/  \__|    |_________|    |________|     `._____.'     `.____.'   |_____||_____|   |_________|");
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
