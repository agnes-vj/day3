using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class task05
    {
        public static void Run()
        {
            int intNum;
            decimal decimalNum;
            Console.WriteLine("Enter a integer number :");
            intNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter a decimal number :");
            decimalNum = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("You've entered " + intNum + " and " + decimalNum);

            double result = (double)(decimalNum / intNum);
            Console.WriteLine( decimalNum + " / " + intNum + " = " + result);
        }
    }
}
