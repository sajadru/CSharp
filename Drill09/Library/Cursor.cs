using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Cursor
    {
        public void Welcome(int left, int top)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(left, top);

        }
        public void Cur(int left, int top)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(left, top);

        }
    }
}
