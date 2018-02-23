using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = { 4, 5};
            double average;
            Console.WriteLine(ParameterModifiers.ComputeAverage(4, 5));
            Console.ReadKey();
            ParameterModifiers.AnotherAverage(numbers, out average);
            Console.WriteLine(average);
            Console.ReadKey();
        }
    }
}
