﻿using System;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna numero: ");
            string line = Console.ReadLine();
            int luku;
            bool result = Int32.TryParse(line, out luku);
            if (result)
            {
                switch (luku)
                {
                    case 1: Console.WriteLine("Yksi"); break;
                    case 2: Console.WriteLine("KA12AAAAAA3123KSI"); break;
                    case 3: Console.WriteLine("Kolme"); break;
                    default: Console.WriteLine("Joku muu luku"); break;

                }

            }
            else
            {
                Console.WriteLine("Voisit antaa numeron kun pyydan!");
            }
            Console.ReadLine();
        }
    }
}
//