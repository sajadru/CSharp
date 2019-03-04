﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class Question
    {
        public int RowNumber { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return $"{RowNumber}.{Text}";
        }
    }
}
