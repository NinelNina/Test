﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    
    class Program
    {
        static void Main()
        {
            CLI.Welcome();

            Student student = CLI.InputStudent();

            Console.ReadKey();
        }
    }
}
