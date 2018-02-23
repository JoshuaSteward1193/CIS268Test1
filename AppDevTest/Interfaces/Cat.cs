using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Cat : IAnimal
    {
        int Age { get; set; }
        double Weight { get; set; }
        bool IsVaccinated { get; set; }

        public Cat(int a, double w, bool v)
        {
            Age = a;
            Weight = w;
            IsVaccinated = v;
        }
        public void move()
        {
            
            Console.WriteLine("I'm a cat and I'm moving!");
        }
    }
}
