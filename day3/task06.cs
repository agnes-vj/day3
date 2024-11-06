using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class task06
    {
        internal static void divide()
        {
            int intVal;
            decimal decimalVal;
            double result;

            Console.Write(" Enter a integer value :");
            intVal = Convert.ToInt16(Console.ReadLine());
            Console.Write(" Enter a double value :");
            decimalVal = decimal.Parse(Console.ReadLine());
            result = (double)(intVal / decimalVal);
            Console.WriteLine(" Result- Converted to double value : " + result);

        }
    }
}
