using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat(2, 15, true);
            kitty.move();
            Console.ReadKey();
        }
    }
}
