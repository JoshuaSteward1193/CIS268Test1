using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDevTest
{
    class Dog : Animal
    {
        string Breed { get; set; }
        bool IsVaccinated { get; set; }

        public Dog(int a, double w, string b, bool v)
        {
            Age = a;
            Weight = w;
            Breed = b;
            IsVaccinated = v;
        }

        public override void move()
        {
            Console.WriteLine("I'm a dog and I'm moving!");
        }
    }    
}
