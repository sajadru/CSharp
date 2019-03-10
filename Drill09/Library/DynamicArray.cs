using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class DynamicArray
    {
        public void AddArray(ref Book[] Arr)
        {
            Book[] Arr2 = new Book[Arr.Length+1];
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = Arr2[i];
            }
            
            Arr = Arr2;
        }

        public void DeleteArray(ref string[] Arr,string x)
        {
            string[] Arr2 = new string[Arr.Length - 1];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] != x)
                {
                    Arr[i] = Arr2[i];
                }
            }
            Arr = Arr2;
        }
        public void EditArray(ref string[] Arr, string x,string y)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == x)
                {
                    Arr[i] = y;
                }
            }
        }
    }
}
