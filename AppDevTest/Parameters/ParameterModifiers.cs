using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class ParameterModifiers
    {
        
        public static double ComputeAverage(params double[] paramList)
        {
            double sum = paramList.Sum();
            return sum / paramList.Length;
        }
        public static void AnotherAverage(double[] numbers, out double average)
        {
            double sum = numbers.Sum();
            average = sum / numbers.Length;
        }
        public static void RemoveFirst(ref int[] array)
        {
            array = array.Skip(1).ToArray();
        }
    }
}
