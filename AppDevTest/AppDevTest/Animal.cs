using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTest
{
    abstract class Animal
    {
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal(int Age = 1, double Weight = 10.0)
        {           
        }

        public abstract void move();

    }
}
