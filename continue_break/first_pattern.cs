﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_break
{
    internal class first_pattern
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5; i++)
            {
                for(int j=1;j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------");
            //----------------------------------------------------------

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
