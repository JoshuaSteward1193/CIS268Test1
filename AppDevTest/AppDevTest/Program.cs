﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doggy = new Dog(5, 30, "Poodle", true);
            doggy.move();
            Console.ReadKey();
        }
    }
}
