﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
        
           
            // Welcome w = new Welcome();
            // w.Header();

            HomePage h = new HomePage();
            h.List();
           // ShowPage s = new ShowPage();
           // s.ShowBook();
            Console.ReadKey();
            
        }

    }
}
