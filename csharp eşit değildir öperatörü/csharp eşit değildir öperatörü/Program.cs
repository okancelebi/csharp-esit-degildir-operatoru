﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_eşit_değildir_öperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Eşit değildir operatörü = !=
            int sayi1 = 5;
            int sayi2 = 5;
            bool kontrolet = sayi1 != sayi2;
            Console.WriteLine(kontrolet);
            Console.ReadLine();
        }
    }
}
